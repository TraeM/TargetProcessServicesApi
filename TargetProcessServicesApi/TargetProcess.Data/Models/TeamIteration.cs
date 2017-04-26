using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A single iteration results in an increment(s) of product functionality. Team iteration should relate to a Team.
    /// </summary>
    [DataContract]
    public class TeamIteration : General

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
        ///     Units of measure for velocity
        /// </summary>
        [DataMember]
        public string Units { get; set; }

        /// <summary>
        ///     End date predicted on current progress if elapsed time is greater than one week and progress is greater than 10%
        /// </summary>
        [DataMember]
        public DateTime? ForecastEndDate { get; set; }

        /// <summary>
        ///     Determines whether iteration can be finished
        /// </summary>
        [DataMember]
        public bool? CanBeFinished { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Team where this iteration is found
        /// </summary>
        [DataMember]
        public Team Team { get; set; }

        /// <summary>
        ///     Collection of assignables found in team iteration
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        ///     Collection of user stories found in team iteration
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of tasks found in team iteration
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of bugs found in team iteration
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of test plan runs found in iteration
        /// </summary>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }

        /// <summary>
        ///     Collection of test plans found in team iteration
        /// </summary>
        [DataMember]
        public TestPlan[] TestPlans { get; set; }
    }
}