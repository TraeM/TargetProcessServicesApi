using System;
using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Assignment of the Team with a specific State on Assignable. Known as TeamState.
    /// </summary>
    [DataContract]
    public class TeamAssignment

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Team Team { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Assignable Assignable { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public EntityState EntityState { get; set; }
    }
}