namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.Attributes
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    sealed class UseInterceptorAttribute : Attribute
    {
        public UseInterceptorAttribute()
        {
        }
    }
}
