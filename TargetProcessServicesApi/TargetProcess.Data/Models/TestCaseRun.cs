using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A single Test Case Run. TestCase can be run many times. It is impossible to create a Test Case Run, instead Add
    ///     Test Case to Test Plan to create a Test Case Run
    /// </summary>
    [DataContract]
    public class TestCaseRun

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Comment { get; set; }

        /// <summary>
        ///     Represents date when Test Case Run passed or failed status was set.
        /// </summary>
        [DataMember]
        public DateTime? EndRunDate { get; set; }

        /// <summary>
        ///     Represents date when Test Case Run first Test Step Run was run
        /// </summary>
        [DataMember]
        public DateTime? StartRunDate { get; set; }

        /// <summary>
        ///     Status of test case run
        /// </summary>
        [DataMember]
        public TestCaseRunStatus Status { get; set; }

        /// <summary>
        ///     Name of the test case run
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Description of the test case run
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Steps { get; set; }

        [DataMember]
        public string Success { get; set; }

        [DataMember]
        public TestPlanRun TestPlanRun { get; set; }

        /// <summary>
        ///     Root test plan run of a test case run
        /// </summary>
        [DataMember]
        public TestPlanRun RootTestPlanRun { get; set; }

        [DataMember]
        public TestCase TestCase { get; set; }

        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Test case run priority
        /// </summary>
        [DataMember]
        public Priority Priority { get; set; }

        /// <summary>
        ///     Last user who runned a test case run
        /// </summary>
        [DataMember]
        public User LastExecutor { get; set; }

        /// <summary>
        ///     Collection of Test Step Runs
        /// </summary>
        [DataMember]
        public TestStepRun[] TestStepRuns { get; set; }

        /// <summary>
        ///     Collection of bugs for a test case run
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of links of this test case run to all its parent test plan runs
        /// </summary>
        [DataMember]
        public TestRunItemHierarchyLink[] TestPlanRunLinks { get; set; }
    }
}