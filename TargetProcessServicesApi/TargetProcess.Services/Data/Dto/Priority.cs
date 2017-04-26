using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Priority of User Story, Bug or Feature. Examples: Must Have, Nice to Have.
    /// </summary>
    [DataContract]
    public class Priority

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Priority name e.g. Must Have
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Priority importance. Minimal value is of the highest importance.
        /// </summary>
        [DataMember]
        public int? Importance { get; set; }

        /// <summary>
        ///     Determines whether priority is default
        /// </summary>
        [DataMember]
        public bool? IsDefault { get; set; }

        /// <summary>
        ///     Type of entity
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }
    }
}