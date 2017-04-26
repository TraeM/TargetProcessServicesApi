using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Milestones for projects
    /// </summary>
    [DataContract]
    public class Milestone

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Milestone name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Milestone description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Milestone date
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        ///     Milestone css class
        /// </summary>
        [DataMember]
        public string CssClass { get; set; }

        /// <summary>
        ///     Person who owns entity
        /// </summary>
        [DataMember]
        public User Owner { get; set; }

        /// <summary>
        ///     Collection of projects for entity
        /// </summary>
        [DataMember]
        public Project[] Projects { get; set; }
    }
}