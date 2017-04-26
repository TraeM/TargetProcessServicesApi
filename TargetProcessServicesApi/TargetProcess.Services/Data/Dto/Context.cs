using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Context contains information about logged User, Culture, selected Projects and Processes.
    /// </summary>
    [DataContract]
    public class Context

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Application context ID. Unique value for a set of projects
        /// </summary>
        [DataMember]
        public string Acid { get; set; }

        /// <summary>
        ///     Target Process edition
        /// </summary>
        [DataMember]
        public string Edition { get; set; }

        /// <summary>
        ///     Target Process version
        /// </summary>
        [DataMember]
        public string Version { get; set; }

        /// <summary>
        ///     Flag to identify if context is full
        /// </summary>
        [DataMember]
        public bool? IsFull { get; set; }

        /// <summary>
        ///     Flag to identify if any project is selected
        /// </summary>
        [DataMember]
        public bool? AnyProject { get; set; }

        /// <summary>
        ///     Flag to identify if any team is selected
        /// </summary>
        [DataMember]
        public bool? AnyTeam { get; set; }

        /// <summary>
        ///     Flag to identify if no team is included
        /// </summary>
        [DataMember]
        public bool? IsNoTeamIncluded { get; set; }

        /// <summary>
        ///     Logged user
        /// </summary>
        [DataMember]
        public User LoggedUser { get; set; }

        /// <summary>
        ///     Current culture in application
        /// </summary>
        [DataMember]
        public Culture Culture { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public AppContext AppContext { get; set; }

        /// <summary>
        ///     Collection of selected projects in the context
        /// </summary>
        [DataMember]
        public ProjectInfo[] SelectedProjects { get; set; }

        /// <summary>
        ///     Collection of selected teams in the context
        /// </summary>
        [DataMember]
        public TeamInfo[] SelectedTeams { get; set; }

        /// <summary>
        ///     Collection of selected processes in the context
        /// </summary>
        [DataMember]
        public ProcessInfo[] Processes { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public ICustomField[] CustomFields { get; set; }
    }
}