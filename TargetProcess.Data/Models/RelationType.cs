using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Type of relation between Entities.
    /// </summary>
    [DataContract]
    public class RelationType

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     The name of the relation
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     All Relations of this Type.
        /// </summary>
        [DataMember]
        public Relation[] Relations { get; set; }
    }
}