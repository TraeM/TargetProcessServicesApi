using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Base entity for Assignable, Build, Impediment, Iteration, Program, Project, Release, Test Case, Test Plan, Bug,
    ///     Feature, Request, Task, Test Plan Run, User Story.
    /// </summary>
    [DataContract]
    public class General : ITargetProcessDto
    {
        /// <summary>
        ///     Entity name or title
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Entity description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///     Start date for timeboxed entities such as Iteration, Project, Release
        /// </summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///     End date for timeboxed entities such as Iteration, Project, Release
        /// </summary>
        [DataMember]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     Entity creation date
        /// </summary>
        [DataMember]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///     Last time entity was modified
        /// </summary>
        [DataMember]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        ///     Last comment date
        /// </summary>
        [DataMember]
        public DateTime? LastCommentDate { get; set; }

        /// <summary>
        ///     Commaseparated list tags
        /// </summary>
        [DataMember]
        public string Tags { get; set; }

        /// <summary>
        ///     Calculated priority of entity
        /// </summary>
        [DataMember]
        public double? NumericPriority { get; set; }

        /// <summary>
        ///     True if entity start date is in the past and end date is in the future
        /// </summary>
        [DataMember]
        public bool? IsNow { get; set; }

        /// <summary>
        ///     True if entity is not in the past and is not current
        /// </summary>
        [DataMember]
        public bool? IsNext { get; set; }

        /// <summary>
        ///     True if entity is in the past
        /// </summary>
        [DataMember]
        public bool? IsPrevious { get; set; }

        /// <summary>
        ///     Last modifier
        /// </summary>
        [DataMember]
        public GeneralUser LastEditor { get; set; }

        /// <summary>
        ///     Person who owns entity
        /// </summary>
        [DataMember]
        public GeneralUser Owner { get; set; }

        /// <summary>
        ///     Last commented user
        /// </summary>
        [DataMember]
        public GeneralUser LastCommentedUser { get; set; }

        /// <summary>
        ///     Project where this entity is found
        /// </summary>
        [DataMember]
        public Project Project { get; set; }

        /// <summary>
        ///     A linked test plan
        /// </summary>
        [DataMember]
        public TestPlan LinkedTestPlan { get; set; }

        /// <summary>
        ///     Custom fields values
        /// </summary>
        [DataMember]
        public Field[] CustomFields { get; set; }

        /// <summary>
        ///     Collection of comments for entity
        /// </summary>
        [DataMember]
        public Comment[] Comments { get; set; }

        /// <summary>
        ///     Collection of messages for entity
        /// </summary>
        [DataMember]
        public Message[] Messages { get; set; }

        /// <summary>
        ///     Collection of tags for entity
        /// </summary>
        [DataMember]
        public Tag[] TagObjects { get; set; }

        /// <summary>
        ///     Collection of related Master entities
        /// </summary>
        [DataMember]
        public Relation[] MasterRelations { get; set; }

        /// <summary>
        ///     Collection of related Slave entities
        /// </summary>
        [DataMember]
        public Relation[] SlaveRelations { get; set; }

        /// <summary>
        ///     Collection of followers
        /// </summary>
        [DataMember]
        public GeneralFollower[] Followers { get; set; }

        /// <summary>
        ///     Inbound Assignable relations.
        /// </summary>
        [DataMember]
        public InboundAssignable[] InboundAssignables { get; set; }

        /// <summary>
        ///     Outbound Assignable relations.
        /// </summary>
        [DataMember]
        public OutboundAssignable[] OutboundAssignables { get; set; }

        /// <summary>
        ///     Collection of attachments for entity
        /// </summary>
        [DataMember]
        public Attachment[] Attachments { get; set; }

        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }
    }
}