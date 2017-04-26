using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     A small chunk of work, typically less than 16 hours. Task must relate to User Story. It is not possible to create
    ///     Tasks without User Story.
    /// </summary>
    [DataContract]
    public class Task : Assignable

    {
        /// <summary>
        ///     Deprecated. Use AssignedTeams instead.
        /// </summary>
        [DataMember]
        public Team Team { get; set; }

        /// <summary>
        ///     User story where this task is found
        /// </summary>
        [DataMember]
        public UserStory UserStory { get; set; }

        /// <summary>
        ///     Deprecated. Use AssignedTeams instead.
        /// </summary>
        [DataMember]
        public TeamAssignment TeamStates { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public TaskSimpleHistory History { get; set; }
    }
}