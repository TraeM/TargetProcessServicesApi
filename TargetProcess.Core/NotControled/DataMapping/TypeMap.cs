using System;
using System.Collections.Generic;

namespace TargetProcess.Core.DataMapping
{
    public class TypeMap : ITypeMapping
    {
        private TypeMap() {}

        public TypeMap(IDictionary<string, object> map)
        {
            Map = map;
        }

        public Type TargetType { get; set; }
        public IDictionary<string, object> Map { get; }
    }
}