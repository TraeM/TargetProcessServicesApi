namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Describes the way the request was added.
    /// </summary>
    public enum RequestSource
    {
        None,
        Email,
        Phone,
        Internal,
        External
    }
}