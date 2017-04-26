using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Base entity for Epic, Feature, User Story, Task, Bug, Test Plan, Test Plan Run, Request.
    ///     It can be assigned to people and has workflow.
    /// </summary>
    [DataContract]
    public class Assignable : General

    {
        /// <summary>
        ///     Total efforts for assignable.Read-only calculated field
        /// </summary>
        /// <value>The effort.</value>
        [DataMember]
        [ReadOnly(true)]
        public decimal? Effort { get; set; }

        /// <summary>
        ///     Effort spent on assignment.
        /// </summary>
        /// <value>The effort completed.</value>
        [DataMember]
        public decimal? EffortCompleted { get; set; }

        /// <summary>
        ///     Effort required to complete assignment.
        /// </summary>
        /// <value>The effort to do.</value>
        [DataMember]
        public decimal? EffortToDo { get; set; }

        /// <summary>
        ///     Percent done for assignable
        /// </summary>
        /// <value>The progress.</value>
        [DataMember]
        public decimal? Progress { get; set; }

        /// <summary>
        ///     Total time spent on assignment. Read-only calculated field
        /// </summary>
        /// <value>The time spent.</value>
        [DataMember]
        [ReadOnly(true)]
        public decimal? TimeSpent { get; set; }

        /// <summary>
        ///     Total time remaining to complete assignment for Role. Read-only calculated field
        /// </summary>
        /// <value>The time remain.</value>
        [DataMember]
        [ReadOnly(true)]
        public decimal? TimeRemain { get; set; }

        /// <summary>
        ///     Last time entity changed state
        /// </summary>
        /// <value>The last state change date.</value>
        [DataMember]
        public DateTime? LastStateChangeDate { get; set; }

        /// <summary>
        ///     Planned Start date for time-boxed entities such as Assignable, Project or Impediment
        /// </summary>
        /// <value>The planned start date.</value>
        [DataMember]
        public DateTime? PlannedStartDate { get; set; }

        /// <summary>
        ///     Planned End date for time-boxed entities such as Assignable, Project or Impediment
        /// </summary>
        /// <value>The planned end date.</value>
        [DataMember]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        ///     Units of measure for velocity
        /// </summary>
        /// <value>The units.</value>
        [DataMember]
        public string Units { get; set; }

        /// <summary>
        ///     Number of days between assignable create date and end date
        /// </summary>
        /// <value>The lead time.</value>
        [DataMember]
        public double? LeadTime { get; set; }

        /// <summary>
        ///     Number of days between assignable start date and end date
        /// </summary>
        /// <value>The cycle time.</value>
        [DataMember]
        public double? CycleTime { get; set; }

        /// <summary>
        ///     End date predicted on current progress if elapsed time is greater than one
        /// </summary>
        /// <value>The forecast end date.</value>
        [DataMember]
        public DateTime? ForecastEndDate { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        /// <value>The type of the entity.</value>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Gets or sets the release.
        /// </summary>
        /// <value>The release.</value>
        [DataMember]
        public Release Release { get; set; }

        /// <summary>
        ///     Gets or sets the iteration.
        /// </summary>
        /// <value>The iteration.</value>
        [DataMember]
        public Iteration Iteration { get; set; }

        /// <summary>
        ///     Gets or sets the team iteration.
        /// </summary>
        /// <value>The team iteration.</value>
        [DataMember]
        public TeamIteration TeamIteration { get; set; }

        /// <summary>
        ///     Gets or sets the priority.
        /// </summary>
        /// <value>The priority.</value>
        [DataMember]
        public Priority Priority { get; set; }

        /// <summary>
        ///     Gets or sets the state of the entity.
        /// </summary>
        /// <value>The state of the entity.</value>
        [DataMember]
        public EntityState EntityState { get; set; }

        /// <summary>
        ///     Gets or sets the responsible team.
        /// </summary>
        /// <value>The responsible team.</value>
        [DataMember]
        public TeamAssignment ResponsibleTeam { get; set; }

        /// <summary>
        ///     User assigned to entity
        /// </summary>
        /// <value>The assigned user.</value>
        [DataMember]
        public GeneralUser AssignedUser { get; set; }

        /// <summary>
        ///     People assigned to entity
        /// </summary>
        /// <value>The assignments.</value>
        [DataMember]
        public Assignment[] Assignments { get; set; }

        /// <summary>
        ///     A blocking reason that impedes work on assignable entity
        /// </summary>
        /// <value>The impediments.</value>
        [DataMember]
        public Impediment[] Impediments { get; set; }

        /// <summary>
        ///     Collection of time entries posted to assignable entity
        /// </summary>
        /// <value>The times.</value>
        [DataMember]
        public Time[] Times { get; set; }

        /// <summary>
        ///     Collection of efforts for all roles
        /// </summary>
        /// <value>The role efforts.</value>
        [DataMember]
        public RoleEffort[] RoleEfforts { get; set; }

        /// <summary>
        ///     Collection of assigned efforts for all roles and users
        /// </summary>
        /// <value>The assigned efforts.</value>
        [DataMember]
        public AssignedEffort[] AssignedEfforts { get; set; }

        /// <summary>
        ///     Collection of assignable revisions
        /// </summary>
        /// <value>The revisions.</value>
        [DataMember]
        public Revision[] Revisions { get; set; }

        /// <summary>
        ///     Collection of assigned Teams and their corresponding States
        /// </summary>
        /// <value>The assigned teams.</value>
        [DataMember]
        public TeamAssignment[] AssignedTeams { get; set; }
    }
}