using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Any User that is a part of a Project Team.
    /// </summary>
    [DataContract]
    public class ProjectMember

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? WeeklyAvailableHours { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public DateTime? MembershipStartDate { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public DateTime? MembershipEndDate { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public int? Allocation { get; set; }

        /// <summary>
        ///     True if project member start date is less or equals than now and end date is greater or equals than now otherwise
        ///     false
        /// </summary>
        [DataMember]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Project Project { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public User User { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Role Role { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public UserProjectAllocation[] Allocations { get; set; }
    }
}