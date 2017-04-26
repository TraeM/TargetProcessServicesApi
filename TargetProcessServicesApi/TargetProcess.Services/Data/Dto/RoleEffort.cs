using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Effort for Assignable by Role. For example, User Story can have 5 hours of Developer effort + 3 hours of Tester
    ///     effort. The total effort will be 8 hours.
    /// </summary>
    [DataContract]
    public class RoleEffort

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? InitialEstimate { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? Effort { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? EffortCompleted { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? EffortToDo { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? TimeSpent { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public decimal? TimeRemain { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Assignable Assignable { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Role Role { get; set; }
    }
}