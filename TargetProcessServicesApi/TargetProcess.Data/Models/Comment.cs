using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Can be added to almost any Entity.
    /// </summary>
    [DataContract]
    public class Comment : ITargetProcessDto
    {
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the parent identifier.
        /// </summary>
        /// <value>The parent identifier.</value>
        [DataMember]
        public int? ParentId { get; set; }

        /// <summary>
        ///     Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        [DataMember]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Gets or sets the general.
        /// </summary>
        /// <value>The general.</value>
        [DataMember]
        public General General { get; set; }

        /// <summary>
        ///     Gets or sets the owner.
        /// </summary>
        /// <value>The owner.</value>
        [DataMember]
        public GeneralUser Owner { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? Id { get; set; }
    }
}