using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Used to limit Requests visibility in Help Desk. Requesters from Company A will not see Requests from Company B.
    /// </summary>
    [DataContract]
    public class Company : ITargetProcessDto
    {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [DataMember]
        public string Url { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the projects.
        /// </summary>
        /// <value>The projects.</value>
        [DataMember]
        public Project[] Projects { get; set; }

        /// <summary>
        ///     Gets or sets the requesters.
        /// </summary>
        /// <value>The requesters.</value>
        [DataMember]
        public Requester[] Requesters { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? Id { get; set; }
    }
}