using ExceptionHandlingWithAutofacAndCastleDynamicProxy.DependencyResolvers;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Abstracts;


var resolver = new MyDependencyResolver();
var myService = resolver.GetService<IMyService>();
myService.Set();