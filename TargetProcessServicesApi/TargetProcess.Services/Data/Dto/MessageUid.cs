using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Represents reference to downloaded message
    /// </summary>
    [DataContract]
    public class MessageUid

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     The identity of the message
        /// </summary>
        [DataMember]
        public string Uid { get; set; }

        /// <summary>
        ///     Mail server name
        /// </summary>
        [DataMember]
        public string MailServer { get; set; }

        /// <summary>
        ///     Mail login
        /// </summary>
        [DataMember]
        public string MailLogin { get; set; }
    }
}