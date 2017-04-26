using System;
using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Any User that is a part of a Team.
    /// </summary>
    [DataContract]
    public class TeamMember

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///     Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Gets or sets the team.
        /// </summary>
        /// <value>The team.</value>
        [DataMember]
        public Team Team { get; set; }

        /// <summary>
        ///     Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [DataMember]
        public User User { get; set; }

        /// <summary>
        ///     Gets or sets the role.
        /// </summary>
        /// <value>The role.</value>
        [DataMember]
        public Role Role { get; set; }
    }
}