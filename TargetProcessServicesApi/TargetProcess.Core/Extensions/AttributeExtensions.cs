using System;
using System.Linq;
using System.Reflection;

namespace TargetProcess.Core.Extensions
{
    public static class AttributeExtensions
    {
        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type,
                                                                   Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            var att = type.GetTypeInfo().GetCustomAttributes<TAttribute>(false).FirstOrDefault();
            return att != null? valueSelector(att) : default(TValue);
        }

        public static TValue GetAttributeValue<TAttribute, TValue>(this MemberInfo memberInfo,
                                                                   Func<TAttribute, TValue> valueSelector)
            where TAttribute : Attribute
        {
            var att = memberInfo.GetCustomAttributes<TAttribute>().FirstOrDefault();
            return att != null? valueSelector(att) : default(TValue);
        }

        public static bool HasAttributeOfType<TAttribute>(this MemberInfo propertyInfo)
            where TAttribute : Attribute
        {
            return propertyInfo.GetCustomAttributes<TAttribute>().Any(attr => attr.GetType() == typeof(TAttribute));
        }
    }
}