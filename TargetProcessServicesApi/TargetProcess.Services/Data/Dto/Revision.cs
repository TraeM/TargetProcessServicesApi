using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     A single commit int?o repository. Contains a set of source files.
    /// </summary>
    [DataContract]
    public class Revision

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     VCSrelated Id
        /// </summary>
        [DataMember]
        public string SourceControlId { get; set; }

        /// <summary>
        ///     Revision description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Commit date
        /// </summary>
        [DataMember]
        public DateTime? CommitDate { get; set; }

        /// <summary>
        ///     Project where the revision is found
        /// </summary>
        [DataMember]
        public Project Project { get; set; }

        /// <summary>
        ///     Commit author
        /// </summary>
        [DataMember]
        public User Author { get; set; }

        /// <summary>
        ///     List of files changed in revision
        /// </summary>
        [DataMember]
        public RevisionFile[] RevisionFiles { get; set; }

        /// <summary>
        ///     List of related assignables
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }
    }
}