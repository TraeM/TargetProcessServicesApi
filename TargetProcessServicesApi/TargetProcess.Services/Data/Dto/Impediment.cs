using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Anything that prevents a team member from working as efficiently as possible. Impediment can relate to Task, User
    ///     Story, Bug or Feature.
    /// </summary>
    [DataContract]
    public class Impediment : General

    {
        /// <summary>
        ///     Determines whether impediment is private
        /// </summary>
        [DataMember]
        public bool? IsPrivate { get; set; }

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
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Assignable entity to which impediment belongs
        /// </summary>
        [DataMember]
        public Assignable Assignable { get; set; }

        /// <summary>
        ///     Entity state of impediment
        /// </summary>
        [DataMember]
        public EntityState EntityState { get; set; }

        /// <summary>
        ///     Impediment priority
        /// </summary>
        [DataMember]
        public Priority Priority { get; set; }

        /// <summary>
        ///     Person responsible for impediment resolution
        /// </summary>
        [DataMember]
        public User Responsible { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public ImpedimentSimpleHistory[] History { get; set; }
    }
}