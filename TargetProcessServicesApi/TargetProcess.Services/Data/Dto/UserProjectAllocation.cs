using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     User allocation to a Project
    /// </summary>
    [DataContract]
    public class UserProjectAllocation : ProjectAllocation

    {
        /// <summary>
        ///     Project Member of User allocation to a Project
        /// </summary>
        [DataMember]
        public ProjectMember ProjectMember { get; set; }
    }
}