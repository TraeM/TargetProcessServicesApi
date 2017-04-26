using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Set of practices, terms, workflows and custom fields that can be applied to Project.
    /// </summary>
    [DataContract]
    public class Process

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Process name e.g. Simplified
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Brief process description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Projects with process
        /// </summary>
        [DataMember]
        public Project[] Projects { get; set; }

        /// <summary>
        ///     Practices for process
        /// </summary>
        [DataMember]
        public Practice[] Practices { get; set; }

        /// <summary>
        ///     Custom fields for process
        /// </summary>
        [DataMember]
        public ICustomField[] CustomFields { get; set; }

        /// <summary>
        ///     Users with admin rights for the Process
        /// </summary>
        [DataMember]
        public User[] ProcessAdmins { get; set; }

        [DataMember]
        public Term[] Terms { get; set; }

        [DataMember]
        public Workflow[] Workflows { get; set; }
    }
}