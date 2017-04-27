using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Tags that can be attached to entities.
    /// </summary>
    [DataContract]
    public class Tag

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Process name e.g. Simplified
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Generals that contains tag
        /// </summary>
        [DataMember]
        public General[] Generals { get; set; }
    }
}