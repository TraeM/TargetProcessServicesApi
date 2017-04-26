#region References

using System;
using System.Runtime.Serialization;

#endregion

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Spent/Remaining time for Assignable (Task, User Story, Bug, etc.).
    /// </summary>
    [DataContract]
    public class Time : ITargetProcessDto
    {
        /// <summary>
        ///     Required if Time Tracking practice 'Mark time description field required' option is enabled
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     User story of the time
        /// </summary>
        [DataMember]
        public UserStory UserStory { get; set; }

        /// <summary>
        ///     Task of the time
        /// </summary>
        [DataMember]
        public Task Task { get; set; }

        /// <summary>
        ///     Bug of the time
        /// </summary>
        [DataMember]
        public Bug Bug { get; set; }

        /// <summary>
        ///     Request of the time
        /// </summary>
        [DataMember]
        public Request Request { get; set; }

        /// <summary>
        ///     Test plan of the time
        /// </summary>
        [DataMember]
        public TestPlan TestPlan { get; set; }

        /// <summary>
        ///     Test plan run of the time
        /// </summary>
        [DataMember]
        public TestPlanRun TestPlanRun { get; set; }

        /// <summary>
        ///     Custom fields values
        /// </summary>
        [DataMember]
        public ICustomField[] CustomFields { get; set; }

        [DataMember]
        public CustomActivity CustomActivity { get; set; }

        [DataMember]
        public Project Project { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember]
        public Role Role { get; set; }

        [DataMember]
        public decimal? Spent { get; set; }

        [DataMember]
        public decimal? Remain { get; set; }

        [DataMember]
        public bool? IsEstimation { get; set; }

        [DataMember]
        public DateTime? Date { get; set; }

        [DataMember]
        public DateTime? CreateDate { get; set; }

        [DataMember]
        public Assignable Assignable { get; set; }

        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }
    }
}