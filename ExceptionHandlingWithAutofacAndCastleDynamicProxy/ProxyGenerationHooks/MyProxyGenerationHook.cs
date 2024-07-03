using Castle.DynamicProxy;
using ExceptionHandlingWithAutofacAndCastleDynamicProxy.Attributes;
using System.Reflection;

namespace ExceptionHandlingWithAutofacAndCastleDynamicProxy.ProxyGenerationHooks
{
    public class MyProxyGenerationHook : IProxyGenerationHook
    {
        public void MethodsInspected()
        {
        }
        public void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
        {
        }
        public bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
        {
            return methodInfo
              .CustomAttributes
              .Any(a => a.AttributeType == typeof(UseInterceptorAttribute));
        }
    }
}
