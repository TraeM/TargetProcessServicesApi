using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Beta version: Term in Process. Like Bug, User Story, Feature, etc.
    /// </summary>
    [DataContract]
    public class Term

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Term word
        /// </summary>
        [DataMember]
        public string WordKey { get; set; }

        /// <summary>
        ///     Term value
        /// </summary>
        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public Process Process { get; set; }

        [DataMember]
        public EntityType EntityType { get; set; }
    }
}