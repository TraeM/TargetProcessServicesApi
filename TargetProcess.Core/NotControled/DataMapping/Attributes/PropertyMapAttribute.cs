using System;

namespace TargetProcess.Core.DataMapping.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PropertyMapAttribute : Attribute
    {
        public string MappedProperty { get; }
        public object PropertyValue { get; set; }

        private PropertyMapAttribute() {}

        public PropertyMapAttribute(string mappedProperty)
        {
            MappedProperty = mappedProperty;
        }
    }
}