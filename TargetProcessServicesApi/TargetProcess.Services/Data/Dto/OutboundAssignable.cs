using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Outbound relation for Assignable.
    /// </summary>
    [DataContract]
    public class OutboundAssignable : Assignable

    {
        /// <summary>
        ///     Type of the relation.
        /// </summary>
        [DataMember]
        public RelationType RelationType { get; set; }

        /// <summary>
        ///     Inbound General.
        /// </summary>
        [DataMember]
        public General InboundGeneral { get; set; }
    }
}