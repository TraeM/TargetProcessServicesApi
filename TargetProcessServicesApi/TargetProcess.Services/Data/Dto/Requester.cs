using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Represents a requester.
    /// </summary>
    [DataContract]
    public class Requester : GeneralUser

    {
        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Notes { get; set; }

        /// <summary>
        ///     Describes the way the requester was added
        /// </summary>
        [DataMember]
        public RequesterSourceTypeEnum SourceType { get; set; }

        [DataMember]
        public Company Company { get; set; }
    }
}