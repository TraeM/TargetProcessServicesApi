using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Type of request (Idea, Issue or Question).
    /// </summary>
    [DataContract]
    public class RequestType

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Name of type
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Icon of type
        /// </summary>
        [DataMember]
        public string Icon { get; set; }

        /// <summary>
        ///     Collection of requests of this type
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }
    }
}