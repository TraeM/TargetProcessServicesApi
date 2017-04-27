using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Practice

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Practice name. For example: Planning
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Practice description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Practice display name. For example: Planning
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Processes owning this practice
        /// </summary>
        [DataMember]
        public Process[] Processes { get; set; }
    }
}