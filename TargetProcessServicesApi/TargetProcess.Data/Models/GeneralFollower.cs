using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Relation between user and following entity.
    /// </summary>
    [DataContract]
    public class GeneralFollower

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
        public General General { get; set; }

        /// <summary>
        ///     The secondary entity in the relation.
        /// </summary>
        [DataMember]
        public User User { get; set; }
    }
}