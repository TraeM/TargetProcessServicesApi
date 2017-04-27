using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Defines permissions for User.
    /// </summary>
    [DataContract]
    public class Role

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool? HasEffort { get; set; }

        [DataMember]
        public bool? CanChangeOwner { get; set; }

        [DataMember]
        public RoleEffort[] RoleEfforts { get; set; }

        [DataMember]
        public EntityState[] EntityStates { get; set; }
    }
}