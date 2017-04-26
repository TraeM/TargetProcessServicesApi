using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    ///     A single TestPlan Run. TestPlan can have multiple runs by various Iterations, Releases or Builds.
    /// </summary>
    [DataContract]
    public class TestPlanRun : Assignable {}
}