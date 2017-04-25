using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Type of Entity. For example: Bug, TestCase, Project.
    /// </summary>
    [DataContract]
    public class EntityType

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Entity type name e.g. Bug, TestCase, Project.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Scope of custom fields for entity type, e.g. None, Process, Global
        /// </summary>
        [DataMember]
        public CustomFieldScope CustomFieldScope { get; set; }

        /// <summary>
        ///     Shows if entities of this entity type can be searched.
        /// </summary>
        [DataMember]
        public bool? IsSearchable { get; set; }

        /// <summary>
        ///     Shows that this entity has effort measurement only in hours.
        /// </summary>
        [DataMember]
        public bool? IsUnitInHourOnly { get; set; }

        /// <summary>
        ///     Shows if this entity is assignable.
        /// </summary>
        [DataMember]
        public bool? IsAssignable { get; set; }

        /// <summary>
        ///     Shows if entity type can be extended with custom fields.
        /// </summary>
        [DataMember]
        public bool? IsExtendable { get; set; }
    }
}