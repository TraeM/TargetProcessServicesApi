using System;

namespace TargetProcess
{
    public interface ICustomFieldService {}

    [Obsolete("Not currently being used", true)]
    class CustomFieldService : ICustomFieldService {}
}