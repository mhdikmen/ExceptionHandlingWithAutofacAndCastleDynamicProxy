using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Attributes;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Abstracts
{
    public interface IMyService
    {
        [UseInterceptor]
        public void Get();
        public void Set();
    }
}
