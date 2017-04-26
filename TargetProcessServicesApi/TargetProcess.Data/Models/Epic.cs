using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A high-level scope of work which contains Features. Can be assigned to Release. Can't be assigned to Iteration.
    /// </summary>
    [DataContract]
    public class Epic : Assignable

    {
        /// <summary>
        ///     Initially estimated effort
        /// </summary>
        [DataMember]
        public decimal? InitialEstimate { get; set; }

        /// <summary>
        ///     Deprecated. Use AssignedTeams instead.
        /// </summary>
        [DataMember]
        public Team Team { get; set; }

        /// <summary>
        ///     Collection of features for epic
        /// </summary>
        [DataMember]
        public Feature[] Features { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public EpicSimpleHistory[] History { get; set; }
    }
}