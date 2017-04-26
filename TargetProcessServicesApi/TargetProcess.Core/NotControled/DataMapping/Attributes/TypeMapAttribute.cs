using System;

namespace TargetProcess.Core.DataMapping.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TypeMapAttribute : Attribute
    {
        public Type MapType { get; }

        private TypeMapAttribute() {}

        public TypeMapAttribute(Type mapType)
        {
            MapType = mapType;
        }
    }
}