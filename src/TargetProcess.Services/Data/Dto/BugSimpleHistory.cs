using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    [DataContract]
    public class BugSimpleHistory : SimpleHistory
    {
        /// <summary>
        ///     What entity was changed
        /// </summary>
        [DataMember]
        public Bug Bug { get; set; }
    }
}