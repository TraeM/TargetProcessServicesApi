using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using TargetProcess.Core.DataMapping.Attributes;
using TargetProcess.Core.Extensions;

namespace TargetProcess.Core.DataMapping
{
    public static class MappingUtility
    {
        public static TypeMap GenerateMap<T>(T obj)
        {
            var map = new TypeMap(MapProperties(obj))
            {
                TargetType = typeof(T).GetAttributeValue((TypeMapAttribute mapAttr) => mapAttr.MapType)
            };
            return map;
        }

        public static IDictionary<string, object> MapProperties<T>(T obj)
        {
            var publicProperties = typeof(T).GetRuntimeProperties().Where(prop => prop.SetMethod.IsPublic);
            var map = new Dictionary<string, object>();
            foreach (var propertyInfo in publicProperties)
            {
                var name = propertyInfo.HasAttributeOfType<PropertyMapAttribute>()
                    ? propertyInfo.GetAttributeValue((PropertyMapAttribute attribute) => attribute.MappedProperty)
                    : propertyInfo.Name;

                map.Add(name, propertyInfo.GetValue(obj));
            }

            return map;
        }
    }
}