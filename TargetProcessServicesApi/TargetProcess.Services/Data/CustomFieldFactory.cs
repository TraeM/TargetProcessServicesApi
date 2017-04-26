using System;

using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services.Data
{
    public static class CustomFieldFactory
    {
        public static Field GenerateField<T>(Action<T> initialization) where T : ICustomField
        {
            var instance = Activator.CreateInstance<T>();
            initialization(instance);

            //BUG Effing Stupid hack
            return instance.ToCustomField();
        }
    }
}