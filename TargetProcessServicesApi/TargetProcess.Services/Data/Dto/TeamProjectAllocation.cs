using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Team allocation to a Project
    /// </summary>
    [DataContract]
    public class TeamProjectAllocation : ProjectAllocation

    {
        /// <summary>
        ///     Team Project of team allocation to a Project
        /// </summary>
        [DataMember]
        public TeamProject TeamProject { get; set; }
    }
}