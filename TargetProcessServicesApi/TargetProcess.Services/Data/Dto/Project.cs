using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Core entity which contains Releases, Features, User Stories, Bugs, etc.
    /// </summary>
    [DataContract]
    public class Project : General
    {
        /// <summary>
        ///     Total effort for all assignables in project. Readonly calculated field
        /// </summary>
        [DataMember]
        public decimal? Effort { get; set; }

        /// <summary>
        ///     Effort spent on all assignments in project.
        /// </summary>
        [DataMember]
        public decimal? EffortCompleted { get; set; }

        /// <summary>
        ///     Effort required to complete all assignments in project.
        /// </summary>
        [DataMember]
        public decimal? EffortToDo { get; set; }

        /// <summary>
        ///     Defines whether project is active
        /// </summary>
        [DataMember]
        public bool? IsActive { get; set; }

        /// <summary>
        ///     Defines whether project is a product
        /// </summary>
        [DataMember]
        public bool? IsProduct { get; set; }

        /// <summary>
        ///     Project abbreviation
        /// </summary>
        [DataMember]
        public string Abbreviation { get; set; }

        /// <summary>
        ///     Reply mail address
        /// </summary>
        [DataMember]
        public string MailReplyAddress { get; set; }

        /// <summary>
        ///     Color for project
        /// </summary>
        [DataMember]
        public string Color { get; set; }

        /// <summary>
        ///     Percent done for project
        /// </summary>
        [DataMember]
        public decimal? Progress { get; set; }

        /// <summary>
        ///     Planned Start date for timeboxed entities such as Assignable, Project or Impediment
        /// </summary>
        [DataMember]
        public DateTime? PlannedStartDate { get; set; }

        /// <summary>
        ///     Planned End date for timeboxed entities such as Assignable, Project or Impediment
        /// </summary>
        [DataMember]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        ///     Last time entity changed state
        /// </summary>
        [DataMember]
        public DateTime? LastStateChangeDate { get; set; }

        /// <summary>
        ///     Defines whether project is private
        /// </summary>
        [DataMember]
        public bool? IsPrivate { get; set; }

        [DataMember]
        public DateTime? ForecastEndDate { get; set; }

        /// <summary>
        ///     End date predicted on planned duration
        /// </summary>
        [DataMember]
        public DateTime? AnticipatedEndDate { get; set; }

        /// <summary>
        ///     Number of days between project create date and end date
        /// </summary>
        [DataMember]
        public double? LeadTime { get; set; }

        /// <summary>
        ///     Number of days between project start date and end date
        /// </summary>
        [DataMember]
        public double? CycleTime { get; set; }

        /// <summary>
        ///     Units of measure for velocity
        /// </summary>
        [DataMember]
        public string Units { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Program associated with the project
        /// </summary>
        [DataMember]
        public Program Program { get; set; }

        /// <summary>
        ///     Process of the project
        /// </summary>
        [DataMember]
        public Process Process { get; set; }

        /// <summary>
        ///     Entity state of project
        /// </summary>
        [DataMember]
        public EntityState EntityState { get; set; }

        /// <summary>
        ///     Project company
        /// </summary>
        [DataMember]
        public Company Company { get; set; }

        /// <summary>
        ///     Collection of general entities
        /// </summary>
        [DataMember]
        public General[] Generals { get; set; }

        /// <summary>
        ///     Collection of project features
        /// </summary>
        [DataMember]
        public Feature[] Features { get; set; }

        /// <summary>
        ///     Collection of project epics
        /// </summary>
        [DataMember]
        public Epic[] Epics { get; set; }

        /// <summary>
        ///     Collection of project releases
        /// </summary>
        [DataMember]
        public Release[] Releases { get; set; }

        /// <summary>
        ///     Collection of cross project releases
        /// </summary>
        [DataMember]
        public Release[] CrossProjectReleases { get; set; }

        /// <summary>
        ///     Collection of project iterations
        /// </summary>
        [DataMember]
        public Iteration[] Iterations { get; set; }

        /// <summary>
        ///     Collection of project user stories
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of project tasks
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of project bugs
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of project test cases
        /// </summary>
        [DataMember]
        public TestCase[] TestCases { get; set; }

        /// <summary>
        ///     Collection of project test plans
        /// </summary>
        [DataMember]
        public TestPlan[] TestPlans { get; set; }

        /// <summary>
        ///     Collection of project builds
        /// </summary>
        [DataMember]
        public Build[] Builds { get; set; }

        /// <summary>
        ///     Collection of times posted to the project
        /// </summary>
        [DataMember]
        public Time[] Times { get; set; }

        /// <summary>
        ///     Collection of project revisions
        /// </summary>
        [DataMember]
        public Revision[] Revisions { get; set; }

        /// <summary>
        ///     Collection of project custom activities
        /// </summary>
        [DataMember]
        public CustomActivity[] CustomActivities { get; set; }

        /// <summary>
        ///     Project members
        /// </summary>
        [DataMember]
        public ProjectMember[] ProjectMembers { get; set; }

        /// <summary>
        ///     Team projects
        /// </summary>
        [DataMember]
        public TeamProject[] TeamProjects { get; set; }

        /// <summary>
        ///     Collection of requests
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }

        /// <summary>
        ///     Collection of test plan runs
        /// </summary>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }

        /// <summary>
        ///     Collection of milestones
        /// </summary>
        [DataMember]
        public Milestone[] Milestones { get; set; }

        /// <summary>
        ///     Collection of project allocations
        /// </summary>
        [DataMember]
        public ProjectAllocation[] Allocations { get; set; }
    }
}