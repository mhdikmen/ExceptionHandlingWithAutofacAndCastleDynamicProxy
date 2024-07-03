using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Interceptors;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.ProxyGenerationHooks;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Abstracts;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.DependencyResolvers
{
    public class MyDependencyResolver
    {
        private readonly IContainer _container;
        public MyDependencyResolver()
        {
            _container = BuildContainer();
        }
        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            var proxyGenerationOptions = new ProxyGenerationOptions(new MyProxyGenerationHook());

            builder.RegisterType<MyService>()
                            .As<IMyService>()
                            .EnableInterfaceInterceptors(proxyGenerationOptions)
                           .InterceptedBy(typeof(ExceptionHandlingInterceptor));

            builder.Register(c => new ExceptionHandlingInterceptor());
            return builder.Build();
        }
        public T GetService<T>() where T : class
        {
            var _ = _container.TryResolve(out T? serviceInstance);
            return serviceInstance ?? throw new Exception();
        }
    }
}
