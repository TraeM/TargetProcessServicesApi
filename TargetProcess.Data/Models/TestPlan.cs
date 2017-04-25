using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     A group of TestCases. For example, you can create 'Smoke Tests' TestPlan and add TestCases there.
    /// </summary>
    [DataContract]
    public class TestPlan : Assignable {}
}