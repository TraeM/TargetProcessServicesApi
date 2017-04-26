using System;
using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     A set of steps to determine if a product functionality is working correctly. TestCase relates to User Story.
    /// </summary>
    [DataContract]
    public class TestCase : General

    {
        /// <summary>
        ///     Status of last test case run
        /// </summary>
        [DataMember]
        public TestCaseRunStatus LastRunStatus { get; set; }

        /// <summary>
        ///     Comment that describes failure if it occurred last time
        /// </summary>
        [DataMember]
        public string LastFailureComment { get; set; }

        /// <summary>
        ///     Date when test case was run last time
        /// </summary>
        [DataMember]
        public DateTime? LastRunDate { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        // Bug possible - Marked off in the API documentation
        // but did not contain an explination
        //[DataMember]public UserStory UserStory { get; set; }

        /// <summary>
        ///     Test case priority
        /// </summary>
        [DataMember]
        public Priority Priority { get; set; }

        /// <summary>
        ///     User stories linked to this test case directly or via user story test plan
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of test plans that contain test case
        /// </summary>
        [DataMember]
        public TestPlan[] TestPlans { get; set; }

        [DataMember]
        public TestCaseRun[] TestCaseRuns { get; set; }

        /// <summary>
        ///     Collection of test steps for the test case
        /// </summary>
        [DataMember]
        public TestStep[] TestSteps { get; set; }
    }
}