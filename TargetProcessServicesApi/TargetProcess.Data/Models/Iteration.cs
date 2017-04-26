using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A single iteration results in an increment(s) of product functionality. Iteration should relate to a Release.
    /// </summary>
    [DataContract]
    public class Iteration : General

    {
        [DataMember]
        public bool? IsCurrent { get; set; }

        /// <summary>
        ///     The amount of work that can be done over iteration
        /// </summary>
        [DataMember]
        public decimal? Velocity { get; set; }

        /// <summary>
        ///     Iteration length in weeks
        /// </summary>
        [DataMember]
        public int? Duration { get; set; }

        /// <summary>
        ///     Percent done for iteration
        /// </summary>
        [DataMember]
        public decimal? Progress { get; set; }

        /// <summary>
        ///     Determines whether iteration can be finished
        /// </summary>
        [DataMember]
        public bool? CanBeFinished { get; set; }

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
        ///     Release where this entity is found
        /// </summary>
        [DataMember]
        public Release Release { get; set; }

        /// <summary>
        ///     Collection of assignables found in iteration
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        ///     Collection of user stories found in iteration
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of tasks found in iteration
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of bugs found in iteration
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of test plan runs found in iteration
        /// </summary>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }

        /// <summary>
        ///     Collection of iteration requests
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }

        /// <summary>
        ///     Collection of iteration builds
        /// </summary>
        [DataMember]
        public Build[] Builds { get; set; }
    }
}