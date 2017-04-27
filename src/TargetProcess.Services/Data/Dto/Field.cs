using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Custom field is an entity extension which is declared on a process level. As a result entity can contain declared
    ///     custom field values. Custom fields has following types: Text, DropDown, CheckBox, Url, Date, RichText, Number,
    ///     Entity. See reference for more details.
    /// </summary>
    [DataContract]
    public class Field : ICustomField
    {
        public virtual int? Id { get; set; }

        public virtual bool? EnabledForFilter { get; set; }

        public virtual double? NumericPriority { get; set; }

        public virtual string Name { get; set; }

        public virtual string Value { get; set; }

        public virtual string EntityFieldName { get; set; }

        public virtual FieldType? FieldType { get; set; }

        public virtual bool? Required { get; set; }
    }
}