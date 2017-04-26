using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Group of people working on some projects.
    /// </summary>
    [DataContract]
    public class Team : General

    {
        /// <summary>
        ///     Icon represented by font
        /// </summary>
        [DataMember]
        public string Icon { get; set; }

        /// <summary>
        ///     Defines whether team is active
        /// </summary>
        [DataMember]
        public bool? IsActive { get; set; }

        /// <summary>
        ///     Team abbreviation
        /// </summary>
        [DataMember]
        public string Abbreviation { get; set; }

        /// <summary>
        ///     Team icon
        /// </summary>
        [DataMember]
        public TpUri IconUri { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Team members
        /// </summary>
        [DataMember]
        public TeamMember[] TeamMembers { get; set; }

        /// <summary>
        ///     Team projects
        /// </summary>
        [DataMember]
        public TeamProject[] TeamProjects { get; set; }

        /// <summary>
        ///     Collection of assignables found in team
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        ///     Collection of user stories found in team
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     Collection of tasks found in team
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of bugs found in team
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of requests found in team
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }

        /// <summary>
        ///     Collection of features found in team
        /// </summary>
        [DataMember]
        public Feature[] Features { get; set; }

        /// <summary>
        ///     Collection of epics found in team
        /// </summary>
        [DataMember]
        public Epic[] Epics { get; set; }

        /// <summary>
        ///     Collection of team iterations
        /// </summary>
        [DataMember]
        public TeamIteration[] TeamIterations { get; set; }

        /// <summary>
        ///     Collection of test plans found in team
        /// </summary>
        [DataMember]
        public TestPlan[] TestPlans { get; set; }

        [DataMember]
        public Workflow[] SuggestedWorkflows { get; set; }
    }
}