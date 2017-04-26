using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    [DataContract]
    public class Assignment
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public Assignable Assignable { get; set; }

        [DataMember]
        public User GeneralUser { get; set; }

        [DataMember]
        public Role Role { get; set; }
    }
}