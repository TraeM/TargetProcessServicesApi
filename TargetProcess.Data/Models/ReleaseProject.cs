using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Project assigned to a release
    /// </summary>
    [DataContract]
    public class ReleaseProject

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public Project Project { get; set; }

        [DataMember]
        public Release Release { get; set; }
    }
}