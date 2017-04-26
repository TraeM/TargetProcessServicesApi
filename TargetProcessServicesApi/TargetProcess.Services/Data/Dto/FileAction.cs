namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Describes what happens with file. The enum is used for Source Control Components.
    /// </summary>
    public enum FileAction
    {
        None,
        Add,
        Delete,
        Modify,
        Rename
    }
}