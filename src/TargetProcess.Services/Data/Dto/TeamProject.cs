using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Any Project in which team participates.
    /// </summary>
    [DataContract]
    public class TeamProject

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public DateTime? StartDate { get; set; }

        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Show if Team has access to Project
        /// </summary>
        [DataMember]
        public bool? IsProjectAccessed { get; set; }

        [DataMember]
        public Team Team { get; set; }

        [DataMember]
        public Project Project { get; set; }

        [DataMember]
        public Workflow[] Workflows { get; set; }

        /// <summary>
        ///     Team project allocations
        /// </summary>
        [DataMember]
        public TeamProjectAllocation[] Allocations { get; set; }
    }
}