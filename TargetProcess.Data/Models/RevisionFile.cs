using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A source file included to Revision.
    /// </summary>
    [DataContract]
    public class RevisionFile

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     File name
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        ///     File change action
        /// </summary>
        [DataMember]
        public FileAction FileAction { get; set; }

        /// <summary>
        ///     File change revision
        /// </summary>
        [DataMember]
        public Revision Revision { get; set; }
    }
}