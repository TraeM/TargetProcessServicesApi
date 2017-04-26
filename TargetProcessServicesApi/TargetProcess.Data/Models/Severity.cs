using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Severity (badness) of Bug. For example, Blocking, Critical, Small.
    /// </summary>
    [DataContract]
    public class Severity

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Severity name. For example: Blocking
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Defines severity importance. Minimal value is of the highest importance
        /// </summary>
        [DataMember]
        public int? Importance { get; set; }

        /// <summary>
        ///     Indicates whether severity is default
        /// </summary>
        [DataMember]
        public bool? IsDefault { get; set; }
    }
}