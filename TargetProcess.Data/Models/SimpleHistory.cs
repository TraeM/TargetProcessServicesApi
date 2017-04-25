using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    public class SimpleHistory
    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Timestamp of the change
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        ///     Effort
        /// </summary>
        [DataMember]
        public decimal? Effort { get; set; }

        /// <summary>
        ///     EffortCompleted
        /// </summary>
        [DataMember]
        public decimal? EffortCompleted { get; set; }

        /// <summary>
        ///     EffortToDo
        /// </summary>
        [DataMember]
        public decimal? EffortToDo { get; set; }

        /// <summary>
        ///     Project
        /// </summary>
        [DataMember]
        public Project Project { get; set; }

        /// <summary>
        ///     Changed entity state
        /// </summary>
        [DataMember]
        public EntityState EntityState { get; set; }

        /// <summary>
        ///     Who performed this change
        /// </summary>
        [DataMember]
        public GeneralUser Modifier { get; set; }

        /// <summary>
        ///     Release
        /// </summary>
        [DataMember]
        public Release Release { get; set; }

        /// <summary>
        ///     Iteration
        /// </summary>
        [DataMember]
        public Iteration Iteration { get; set; }
    }
}