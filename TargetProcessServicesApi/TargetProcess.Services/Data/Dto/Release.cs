using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Delivering an increment(s) of product functionality to
    /// </summary>
    [DataContract]
    public class Release : General

    {
        [DataMember]
        public bool? IsCurrent { get; set; }

        /// <summary>
        ///     Percent done for iteration
        /// </summary>
        [DataMember]
        public decimal? Progress { get; set; }

        /// <summary>
        ///     Units of measure for velocity
        /// </summary>
        [DataMember]
        public string Units { get; set; }

        [DataMember]
        public DateTime? ForecastEndDate { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Process. Used for resolving custom fields, terms and notifications.
        /// </summary>
        [DataMember]
        public Process Process { get; set; }

        /// <summary>
        ///     Collection of iterations inside release
        /// </summary>
        [DataMember]
        public Iteration[] Iterations { get; set; }

        /// <summary>
        ///     Collection of entities it contains
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        ///     Collection of epics it contains
        /// </summary>
        [DataMember]
        public Epic[] Epics { get; set; }

        /// <summary>
        ///     Collection of features it contains
        /// </summary>
        [DataMember]
        public Feature[] Features { get; set; }

        /// <summary>
        ///     Collection of user stories for feature
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of tasks it contains
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of bugs contains
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of test plan runs it contains
        /// </summary>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }

        /// <summary>
        ///     Collection of releases it contains
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }

        /// <summary>
        ///     Collection of builds it contains
        /// </summary>
        [DataMember]
        public Build[] Builds { get; set; }

        /// <summary>
        ///     Collection of release test plans
        /// </summary>
        [DataMember]
        public TestPlan[] TestPlans { get; set; }

        /// <summary>
        ///     Release projects
        /// </summary>
        [DataMember]
        public Project[] Projects { get; set; }
    }
}