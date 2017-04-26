using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Bug or defect (error, flaw, mistake, failure or fault in a computer program).
    ///     Can relate to User Story. Can be assigned to Release and Iteration.
    /// </summary>
    [DataContract]
    public class Bug : Assignable
    {
        /// <summary>
        ///     Build where this bug is found
        /// </summary>
        [DataMember]
        public Build Build { get; set; }

        /// <summary>
        ///     User story where this bug is found
        /// </summary>
        [DataMember]
        public UserStory UserStory { get; set; }

        /// <summary>
        ///     Feature where this bug is found
        /// </summary>
        [DataMember]
        public Feature Feature { get; set; }

        /// <summary>
        ///     Bug severity
        /// </summary>
        [DataMember]
        public Severity Severity { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public BugSimpleHistory[] History { get; set; }

        /// <summary>
        ///     Test case runs where this bug is found in
        /// </summary>
        [DataMember]
        public TestCaseRun[] TestCaseRuns { get; set; }

        /// <summary>
        ///     Test plan runs where this bug is found in
        /// </summary>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }
    }
}