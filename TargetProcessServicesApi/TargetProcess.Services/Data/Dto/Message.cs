using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Email message from email int?egration
    /// </summary>
    [DataContract]
    public class Message
    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Message subject
        /// </summary>
        [DataMember]
        public string Subject { get; set; }

        /// <summary>
        ///     Message recipient
        /// </summary>
        [DataMember]
        public string Recipients { get; set; }

        /// <summary>
        ///     Message body
        /// </summary>
        [DataMember]
        public string Body { get; set; }

        /// <summary>
        ///     Defines if message was read
        /// </summary>
        [DataMember]
        public bool? IsRead { get; set; }

        /// <summary>
        ///     Defines if message was processed by Target Processs
        /// </summary>
        [DataMember]
        public bool? IsProcessed { get; set; }

        [DataMember]
        public DateTime? CreateDate { get; set; }

        [DataMember]
        public DateTime? SendDate { get; set; }

        [DataMember]
        public MessageType MessageType { get; set; }

        [DataMember]
        public ContentType ContentType { get; set; }

        [DataMember]
        public GeneralUser From { get; set; }

        [DataMember]
        public GeneralUser To { get; set; }

        [DataMember]
        public MessageUid MessageUid { get; set; }

        [DataMember]
        public General[] Generals { get; set; }

        [DataMember]
        public Attachment[] Attachments { get; set; }
    }
}