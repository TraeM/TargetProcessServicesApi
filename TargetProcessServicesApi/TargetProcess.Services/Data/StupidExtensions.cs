using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services.Data
{
    public static class StupidExtensions
    {
        public static Field ToCustomField(this ICustomField field) => new Field
        {
            Name = field.Name,
            Value = field.Value,
            Id = field.Id,
            Required = field.Required,
            FieldType = field.FieldType,
            EnabledForFilter = field.EnabledForFilter,
            EntityFieldName = field.EntityFieldName,
            NumericPriority = field.NumericPriority
        };
    }
}