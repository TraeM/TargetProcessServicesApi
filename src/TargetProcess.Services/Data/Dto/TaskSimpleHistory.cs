using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     A change of an entity
    /// </summary>
    [DataContract]
    public class TaskSimpleHistory : SimpleHistory

    {
        /// <summary>
        ///     What entity was changed
        /// </summary>
        [DataMember]
        public Task Task { get; set; }
    }
}