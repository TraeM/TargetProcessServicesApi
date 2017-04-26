using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Set of states
    /// </summary>
    [DataContract]
    public class Workflow

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Workflow name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Projects with process
        /// </summary>
        [DataMember]
        public Process Process { get; set; }

        /// <summary>
        ///     Entity Type workflow defined for
        /// </summary>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Parent Workflow
        /// </summary>
        [DataMember]
        public Workflow ParentWorkflow { get; set; }

        /// <summary>
        ///     Entity States for workflow
        /// </summary>
        [DataMember]
        public EntityState[] EntityStates { get; set; }

        /// <summary>
        ///     Child Workflows
        /// </summary>
        [DataMember]
        public Workflow[] SubWorkflows { get; set; }

        [DataMember]
        public TeamProject[] TeamProjects { get; set; }
    }
}