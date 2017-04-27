namespace TargetProcess.Base
{
    /// <summary>
    ///     Interface ITargetProcessRequirmentsValidation
    /// </summary>
    /// <typeparam name="TDto">The type of Dto.</typeparam>
    public interface ITargetProcessRequirmentsValidation<in TDto>
    {
        bool MeetsServiceRequirments(TDto dto);
    }
}