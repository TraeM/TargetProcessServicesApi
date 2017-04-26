using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Class AssignedEffort.
    /// </summary>
    [DataContract]
    public class AssignedEffort

    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the initial estimate.
        /// </summary>
        /// <value>The initial estimate.</value>
        [DataMember]
        public decimal? InitialEstimate { get; set; }

        /// <summary>
        ///     Gets or sets the effort.
        /// </summary>
        /// <value>The effort.</value>
        [DataMember]
        public decimal? Effort { get; set; }

        /// <summary>
        ///     Gets or sets the effort completed.
        /// </summary>
        /// <value>The effort completed.</value>
        [DataMember]
        public decimal? EffortCompleted { get; set; }

        /// <summary>
        ///     Gets or sets the effort to do.
        /// </summary>
        /// <value>The effort to do.</value>
        [DataMember]
        public decimal? EffortToDo { get; set; }

        /// <summary>
        ///     Gets or sets the role time spent.
        /// </summary>
        /// <value>The role time spent.</value>
        [DataMember]
        public decimal? RoleTimeSpent { get; set; }

        /// <summary>
        ///     Gets or sets the role time remain.
        /// </summary>
        /// <value>The role time remain.</value>
        [DataMember]
        public decimal? RoleTimeRemain { get; set; }

        /// <summary>
        ///     Gets or sets the assignable.
        /// </summary>
        /// <value>The assignable.</value>
        [DataMember]
        public Assignable Assignable { get; set; }

        /// <summary>
        ///     Gets or sets the role.
        /// </summary>
        /// <value>The role.</value>
        [DataMember]
        public Role Role { get; set; }

        /// <summary>
        ///     Gets or sets the general user.
        /// </summary>
        /// <value>The general user.</value>
        [DataMember]
        public User GeneralUser { get; set; }
    }
}