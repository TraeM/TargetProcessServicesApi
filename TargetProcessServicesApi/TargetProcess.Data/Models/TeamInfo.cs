using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class TeamInfo

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Team name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Team abbreviation
        /// </summary>
        [DataMember]
        public string Abbreviation { get; set; }

        /// <summary>
        ///     Team icon
        /// </summary>
        [DataMember]
        public string Icon { get; set; }
    }
}