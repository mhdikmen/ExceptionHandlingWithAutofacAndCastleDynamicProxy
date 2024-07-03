using Castle.DynamicProxy;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.Interceptors
{
    public class ExceptionHandlingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
			try
			{
				invocation.Proceed();
			}
			catch (Exception)
			{

			}
        }
    }
}
