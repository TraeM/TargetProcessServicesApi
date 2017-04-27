using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Several Projects can be grouped int?o a Program.
    /// </summary>
    [DataContract]
    public class Program : General
    {
        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Collection of projects
        /// </summary>
        [DataMember]
        public Project[] Projects { get; set; }
    }
}