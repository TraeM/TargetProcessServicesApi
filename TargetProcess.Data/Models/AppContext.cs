using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    [DataContract]
    public class AppContext
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public SimpleContext TeamContext { get; set; }
    }
}