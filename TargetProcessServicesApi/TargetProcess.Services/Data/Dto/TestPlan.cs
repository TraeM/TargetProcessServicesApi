using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     A group of TestCases. For example, you can create 'Smoke Tests' TestPlan and add TestCases there.
    /// </summary>
    [DataContract]
    public class TestPlan : Assignable {}
}