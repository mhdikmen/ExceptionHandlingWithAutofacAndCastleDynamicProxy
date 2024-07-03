using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Abstracts;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.Services.Concretes
{
    public class MyService : IMyService
    {
        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Set()
        {
            throw new NotImplementedException();
        }
    }
}
