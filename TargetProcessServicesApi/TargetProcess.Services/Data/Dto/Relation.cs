using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Relation between two Entities.
    /// </summary>
    [DataContract]
    public class Relation

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     The main entity in the relation.
        /// </summary>
        [DataMember]
        public General Master { get; set; }

        /// <summary>
        ///     The secondary entity in the relation.
        /// </summary>
        [DataMember]
        public General Slave { get; set; }

        /// <summary>
        ///     Type of the relation.
        /// </summary>
        [DataMember]
        public RelationType RelationType { get; set; }
    }
}