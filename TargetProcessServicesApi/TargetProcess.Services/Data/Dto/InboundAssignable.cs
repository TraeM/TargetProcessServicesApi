using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Inbound relation for Assignable.
    /// </summary>
    [DataContract]
    public class InboundAssignable : Assignable

    {
        /// <summary>
        ///     Type of the relation.
        /// </summary>
        [DataMember]
        public RelationType RelationType { get; set; }

        /// <summary>
        ///     Outbound General.
        /// </summary>
        [DataMember]
        public General OutboundGeneral { get; set; }
    }
}