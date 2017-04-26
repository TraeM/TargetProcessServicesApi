using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Link between test plan run and test case run. In hierarchical test plan runs each test case run is linked to all
    ///     parent test plan runs
    /// </summary>
    [DataContract]
    public class TestRunItemHierarchyLink {}
}