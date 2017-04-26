using System;
using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Represents an user. User has Role and can be added to project teams.
    /// </summary>
    [DataContract]
    public class User : GeneralUser

    {
        /// <summary>
        ///     Last login date
        /// </summary>
        [DataMember]
        public DateTime? LastLoginDate { get; set; }

        /// <summary>
        ///     User int?erface locale
        /// </summary>
        [DataMember]
        public string Locale { get; set; }

        /// <summary>
        ///     Collection of user revisions
        /// </summary>
        [DataMember]
        public Revision[] Revisions { get; set; }

        /// <summary>
        ///     Team members
        /// </summary>
        [DataMember]
        public TeamMember[] TeamMembers { get; set; }

        /// <summary>
        ///     Project members
        /// </summary>
        [DataMember]
        public ProjectMember[] ProjectMembers { get; set; }

        /// <summary>
        ///     Milestones
        /// </summary>
        [DataMember]
        public Milestone[] Milestones { get; set; }

        /// <summary>
        ///     Processes for which User have admin rights
        /// </summary>
        [DataMember]
        public Process[] AdminProcesses { get; set; }

        /// <summary>
        ///     Collection of followed entities
        /// </summary>
        [DataMember]
        public GeneralFollower[] Following { get; set; }

        [DataMember]
        public decimal? WeeklyAvailableHours { get; set; }

        [DataMember]
        public int? CurrentAllocation { get; set; }

        [DataMember]
        public decimal? CurrentAvailableHours { get; set; }

        [DataMember]
        public DateTime? AvailableFrom { get; set; }

        [DataMember]
        public int? AvailableFutureAllocation { get; set; }

        [DataMember]
        public decimal? AvailableFutureHours { get; set; }

        [DataMember]
        public bool? IsObserver { get; set; }

        [DataMember]
        public bool? IsContributor { get; set; }

        [DataMember]
        public string Skills { get; set; }

        [DataMember]
        public string ActiveDirectoryName { get; set; }

        [DataMember]
        public Role Role { get; set; }

        [DataMember]
        public Time[] Times { get; set; }

        [DataMember]
        public Impediment[] Impediments { get; set; }

        [DataMember]
        public CustomActivity[] CustomActivities { get; set; }
    }
}