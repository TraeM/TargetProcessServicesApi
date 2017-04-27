using System.Runtime.Serialization;

using TargetProcess.Data.Dto;

namespace TargetProcess.Data
{
    public interface ICustomField
    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        int? Id { get; set; }

        /// <summary>
        ///     Show in lists/Enabled for filter
        /// </summary>
        [DataMember]
        bool? EnabledForFilter { get; set; }

        /// <summary>
        ///     Priority of Custom Field. Used for sorting
        /// </summary>
        [DataMember]
        double? NumericPriority { get; set; }

        /// <summary>
        ///     The name of the custom field
        /// </summary>
        [DataMember]
        string Name { get; set; }

        /// <summary>
        ///     Predefined values of the custom field. Example: possible values for multiselect field
        /// </summary>
        [DataMember]
        string Value { get; set; }

        /// <summary>
        ///     Private custom field name
        /// </summary>
        [DataMember]
        string EntityFieldName { get; set; }

        /// <summary>
        ///     Custom field type: Text, Numeric, etc.
        /// </summary>
        [DataMember]
        FieldType? FieldType { get; set; }

        /// <summary>
        ///     Field value should be set for entity
        /// </summary>
        [DataMember]
        bool? Required { get; set; }
    }
}