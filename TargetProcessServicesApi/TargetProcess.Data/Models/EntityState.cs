using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     State of Entity. Collection of EntityStates form Workflow for Entity. For example, Bug has four EntityStates by
    ///     default: Open, Fixed, Invalid and Done.
    /// </summary>
    [DataContract]
    public class EntityState

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     State name. For example, Open or Done
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Defines if state is initial. Only one initial state is allowed
        /// </summary>
        [DataMember]
        public bool? IsInitial { get; set; }

        /// <summary>
        ///     Defines if the state is final.
        /// </summary>
        [DataMember]
        public bool? IsFinal { get; set; }

        /// <summary>
        ///     Defines if the state is planned.
        /// </summary>
        [DataMember]
        public bool? IsPlanned { get; set; }

        /// <summary>
        ///     Defines whether comment is required if state is changed to another state
        /// </summary>
        [DataMember]
        public bool? IsCommentRequired { get; set; }

        /// <summary>
        ///     Priority of entity. Used for sorting
        /// </summary>
        [DataMember]
        public double? NumericPriority { get; set; }

        /// <summary>
        ///     Responsible role for entity
        /// </summary>
        [DataMember]
        public Role Role { get; set; }

        /// <summary>
        ///     Parent Entity State
        /// </summary>
        [DataMember]
        public EntityState ParentEntityState { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Workflow Workflow { get; set; }

        /// <summary>
        ///     Next states for state
        /// </summary>
        [DataMember]
        public EntityState[] NextStates { get; set; }

        /// <summary>
        ///     Previous states for state
        /// </summary>
        [DataMember]
        public EntityState[] PreviousStates { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Project[] Projects { get; set; }

        /// <summary>
        ///     Child Entity States
        /// </summary>
        [DataMember]
        public EntityState[] SubEntityStates { get; set; }
    }
}