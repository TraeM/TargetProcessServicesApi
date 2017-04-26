using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     A change of an entity
    /// </summary>
    [DataContract]
    public class EpicSimpleHistory : SimpleHistory

    {
        /// <summary>
        ///     What entity was changed
        /// </summary>
        [DataMember]
        public Epic Epic { get; set; }
    }
}