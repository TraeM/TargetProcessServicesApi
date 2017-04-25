using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Base allocation to a Project
    /// </summary>
    [DataContract]
    public class ProjectAllocation

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Manually entered allocation start date
        /// </summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///     Manually entered allocation end date
        /// </summary>
        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Inherits allocation dates if they exist and project dates, if they don’t exist.
        /// </summary>
        [DataMember]
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        ///     Allocation percentage
        /// </summary>
        [DataMember]
        public int? Percentage { get; set; }

        /// <summary>
        ///     Describes if allocation is effective. Only effective allocations are displayed on views and used for calculations.
        /// </summary>
        [DataMember]
        public bool? IsEffective { get; set; }

        /// <summary>
        ///     Inherits allocation dates if they exist and project dates, if they don’t exist.
        /// </summary>
        [DataMember]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        ///     Type of project allocation.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Project of this allocation
        /// </summary>
        [DataMember]
        public Project Project { get; set; }
    }
}