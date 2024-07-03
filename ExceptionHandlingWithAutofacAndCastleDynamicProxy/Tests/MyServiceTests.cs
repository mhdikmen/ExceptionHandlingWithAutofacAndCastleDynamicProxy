using ExceptionHandlingWithAutofacAndCastleDynamicProxy.DependencyResolvers;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Abstracts;
using Xunit;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.Tests
{
    public class MyServiceTests
    {
        [Fact]
        public void Should_Throws_Exception()
        {
            var resolver = new MyDependencyResolver();
            var myService = resolver.GetService<IMyService>();
            Assert.Throws<NotImplementedException>(() =>
            {
                myService.Set();
            });
        }

        [Fact]
        public void Should_Not_Throws_Exception()
        {
            var resolver = new MyDependencyResolver();
            var myService = resolver.GetService<IMyService>();
            myService.Get();
        }
    }
}
