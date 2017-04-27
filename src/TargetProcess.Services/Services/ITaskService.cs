using TargetProcess.Base;
using TargetProcess.Data.Dto;

namespace TargetProcess
{
    public interface ITaskService : ICrudService<Task>, IRestApiService,
                                    ITargetProcessRequirmentsValidation<Task> {}

    /// <summary>
    ///     Class TaskService.
    /// </summary>
    /// <seealso cref="services.Base.CrudService{TargetProcess.Data.Models.Task}" />
    /// <seealso cref="services.ITaskService" />
    class TaskService : CrudService<Task>, ITaskService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public TaskService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Tasks";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Task dto) => dto.Name != null && dto.Project != null;
    }
}