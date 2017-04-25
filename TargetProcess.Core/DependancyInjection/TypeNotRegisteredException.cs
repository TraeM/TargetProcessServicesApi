using System;

namespace TargetProcess.Core.DependancyInjection
{
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException(string message)
            : base(message) {}
    }
}