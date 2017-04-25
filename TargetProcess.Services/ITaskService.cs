using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface ITaskService : ICrudService<Task>, IRestApiService,
                                    ITargetProcessRequirmentsValidation<Task> {}

    /// <summary>
    /// Class TaskService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Task}" />
    /// <seealso cref="TargetProcess.Services.ITaskService" />
    class TaskService : CrudService<Task>, ITaskService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskService"/> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public TaskService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        /// Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Tasks";

        /// <summary>
        /// Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Task dto) => dto.Name != null && dto.Project != null;
    }
}