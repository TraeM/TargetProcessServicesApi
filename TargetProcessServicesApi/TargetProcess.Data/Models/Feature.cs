using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A high-level requirement which contains user stories. Can be assigned to Release. Can't be assigned to Iteration.
    /// </summary>
    [DataContract]
    public class Feature : Assignable

    {
        /// <summary>
        ///     Epic where this feature is found
        /// </summary>
        [DataMember]
        public Epic Epic { get; set; }

        /// <summary>
        ///     Initially estimated effort
        /// </summary>
        [DataMember]
        public decimal? InitialEstimate { get; set; }

        /// <summary>
        ///     Collection of user stories for feature
        /// </summary>
        [DataMember]
        public UserStory[] UserStories { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public FeatureSimpleHistory[] History { get; set; }

        /// <summary>
        ///     Collection of bugs for feature
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }
    }
}