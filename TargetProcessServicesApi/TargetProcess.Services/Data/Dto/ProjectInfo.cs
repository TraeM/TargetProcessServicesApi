using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ProjectInfo

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Project name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Project color
        /// </summary>
        [DataMember]
        public string Color { get; set; }

        /// <summary>
        ///     Project is active
        /// </summary>
        [DataMember]
        public bool? IsActive { get; set; }

        /// <summary>
        ///     Project is private
        /// </summary>
        [DataMember]
        public bool? IsPrivate { get; set; }

        /// <summary>
        ///     Project abbreviation
        /// </summary>
        [DataMember]
        public string Abbreviation { get; set; }

        /// <summary>
        ///     Process to which project info belongs
        /// </summary>
        [DataMember]
        public ProcessInfo Process { get; set; }

        /// <summary>
        ///     Program to which project info belongs
        /// </summary>
        [DataMember]
        public ProgramInfo Program { get; set; }
    }

    /// <summary>
    ///     Information about Program.
    /// </summary>
    [DataContract]
    public class ProgramInfo

    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}