using TargetProcess.Base;
using TargetProcess.Data.Dto;

namespace TargetProcess
{
    public interface IUserStoryService : IRestApiService, ICrudService<UserStory>,
                                         ITargetProcessRequirmentsValidation<UserStory> {}

    /// <summary>
    ///     Class UserStoryService.
    /// </summary>
    /// <seealso cref="services.Base.CrudService{TargetProcess.Data.Models.UserStory}" />
    /// <seealso cref="services.IUserStoryService" />
    public class UserStoryService : CrudService<UserStory>, IUserStoryService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UserStoryService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public UserStoryService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "UserStories";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(UserStory dto) => dto.Name != null && dto.Project != null;
    }
}