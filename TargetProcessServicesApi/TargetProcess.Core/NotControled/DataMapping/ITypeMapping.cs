using System;
using System.Collections.Generic;

namespace TargetProcess.Core.DataMapping
{
    public interface ITypeMapping
    {
        Type TargetType { get; set; }
        IDictionary<string, object> Map { get; }
    }
}