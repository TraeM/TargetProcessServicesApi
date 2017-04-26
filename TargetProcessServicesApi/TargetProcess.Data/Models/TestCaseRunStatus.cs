namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Describes status of Test Case Run.
    /// </summary>
    public enum TestCaseRunStatus
    {
        NotRun,
        Passed,
        Failed,
        OnHold,
        Blocked
    }
}