using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A statement of end user requirements in a couple of sentences. User Story can be assigned to Iteration or Release.
    /// </summary>
    [DataContract]
    public class UserStory : Assignable

    {
        /// <summary>
        ///     Initially estimated user story effort
        /// </summary>
        [DataMember]
        public decimal? InitialEstimate { get; set; }

        /// <summary>
        ///     Feature where this user story is found
        /// </summary>
        [DataMember]
        public Feature Feature { get; set; }

        /// <summary>
        ///     Collection of tasks contained in the user story
        /// </summary>
        [DataMember]
        public Task[] Tasks { get; set; }

        /// <summary>
        ///     Collection of bugs contained in the user story
        /// </summary>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Test cases linked to this user story directly or via user story test plan
        /// </summary>
        [DataMember]
        public TestCase[] UserStoryTestCases { get; set; }

        /// <summary>
        ///     Test plans linked to this user story via user story test plan
        /// </summary>
        [DataMember]
        public TestPlan[] UserStoryTestPlans { get; set; }

        /// <summary>
        ///     History of entity changes
        /// </summary>
        [DataMember]
        public UserStorySimpleHistory[] History { get; set; }
    }
}