using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     Class Build.
    /// </summary>
    [DataContract]
    public class Build : General

    {
        /// <summary>
        ///     Date of build
        /// </summary>
        /// <value>The build date.</value>
        [DataMember]
        public DateTime? BuildDate { get; set; }

        /// <summary>
        ///     Type of entity e.g. Bug, Feature, Task, etc.
        /// </summary>
        /// <value>The type of the entity.</value>
        [DataMember]
        public EntityType EntityType { get; set; }

        /// <summary>
        ///     Release where build is found
        /// </summary>
        /// <value>The release.</value>
        [DataMember]
        public Release Release { get; set; }

        /// <summary>
        ///     Iteration where build is found
        /// </summary>
        /// <value>The iteration.</value>
        [DataMember]
        public Iteration Iteration { get; set; }

        /// <summary>
        ///     Collection of bugs found in build
        /// </summary>
        /// <value>The bugs.</value>
        [DataMember]
        public Bug[] Bugs { get; set; }

        /// <summary>
        ///     Collection of test plan runs perfromed in build
        /// </summary>
        /// <value>The test plan runs.</value>
        [DataMember]
        public TestPlanRun[] TestPlanRuns { get; set; }
    }
}