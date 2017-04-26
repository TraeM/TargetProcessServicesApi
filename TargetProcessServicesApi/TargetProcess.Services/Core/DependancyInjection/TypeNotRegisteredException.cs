using System;

namespace TargetProcess.Services.Core.DependancyInjection
{
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException(string message)
            : base(message) {}
    }
}