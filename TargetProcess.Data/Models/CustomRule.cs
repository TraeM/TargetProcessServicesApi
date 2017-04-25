using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Custom business rules defined by user.
    /// </summary>
    [DataContract]
    public class CustomRule

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Rule name. Simplified
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Brief rule description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Shows if rule is turned on
        /// </summary>
        [DataMember]
        public bool? IsEnabled { get; set; }
    }
}