using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Request can represent Idea, Issue or Question from users. Bugs, User Stories and Features can be linked to
    ///     Requests.
    /// </summary>
    [DataContract]
    public class Request : Assignable

    {
        /// <summary>
        ///     Source of request. Can be Email, Phone, External, Int?ernal
        /// </summary>
        [DataMember]
        public RequestSource SourceType { get; set; }

        /// <summary>
        ///     Determines whether request is replied
        /// </summary>
        [DataMember]
        public bool? IsReplied { get; set; }

        /// <summary>
        ///     Determines whether request is private
        /// </summary>
        [DataMember]
        public bool? IsPrivate { get; set; }

        /// <summary>
        ///     Total number of Requesters/Votes for Request
        /// </summary>
        [DataMember]
        public int? VotesCount { get; set; }

        /// <summary>
        ///     Type of request
        /// </summary>
        [DataMember]
        public RequestType RequestType { get; set; }

        /// <summary>
        ///     Collection of requesters.
        /// </summary>
        [DataMember]
        public GeneralUser[] Requesters { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public RequestSimpleHistory[] History { get; set; }
    }
}