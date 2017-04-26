using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Base entity for User and Requester.
    /// </summary>
    [DataContract]
    public class GeneralUser

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     First Name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        ///     Last Name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        ///     Email
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        ///     Login
        /// </summary>
        [DataMember]
        public string Login { get; set; }

        /// <summary>
        ///     User creation date
        /// </summary>
        [DataMember]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     User last modified date
        /// </summary>
        [DataMember]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        ///     User delete date
        /// </summary>
        [DataMember]
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        ///     Determines whether user is active in the system
        /// </summary>
        [DataMember]
        public bool? IsActive { get; set; }

        /// <summary>
        ///     Determines whether user is administrator
        /// </summary>
        [DataMember]
        public bool? IsAdministrator { get; set; }

        /// <summary>
        ///     Determines type of user
        /// </summary>
        [DataMember]
        public UserEntityKind Kind { get; set; }

        /// <summary>
        ///     Global Unique Identifier
        /// </summary>
        [DataMember]
        public string GlobalId { get; set; }

        /// <summary>
        ///     User password
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        ///     User avatar
        /// </summary>
        [DataMember]
        public TpUri AvatarUri { get; set; }

        /// <summary>
        ///     Custom fields values
        /// </summary>
        [DataMember]
        public ICustomField[] CustomFields { get; set; }

        /// <summary>
        ///     All entities assigned to this user
        /// </summary>
        [DataMember]
        public Assignable[] Assignables { get; set; }

        /// <summary>
        ///     Collection of user comments
        /// </summary>
        [DataMember]
        public Comment[] Comments { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public Request[] Requests { get; set; }
    }
}