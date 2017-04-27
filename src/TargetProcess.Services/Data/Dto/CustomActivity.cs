using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Special type of work you can track Time against.
    /// </summary>
    [DataContract]
    public class CustomActivity
    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime? Created { get; set; }

        [DataMember]
        public decimal? Estimate { get; set; }

        [DataMember]
        public Project Project { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember]
        public Time[] Times { get; set; }
    }
}