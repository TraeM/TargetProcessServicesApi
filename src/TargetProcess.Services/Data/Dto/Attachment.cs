using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    [DataContract]
    public class Attachment
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string UniqueFileName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? Date { get; set; }

        //bug
        [DataMember]
        public string Uri { get; set; }

        //bug
        [DataMember]
        public string ThumbnailUri { get; set; }

        [DataMember]
        public string MimeType { get; set; }

        [DataMember]
        public long Size { get; set; }

        [DataMember]
        public GeneralUser Owner { get; set; }

        [DataMember]
        public General General { get; set; }

        [DataMember]
        public Message Message { get; set; }
    }
}