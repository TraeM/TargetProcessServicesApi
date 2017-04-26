using System;
using System.Threading.Tasks;

using TargetProcess.Services.Base;
using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services
{
    public interface IProjectService : ICrudService<Project>, IUndelete<Project>, IRestApiService,
                                       ITargetProcessRequirmentsValidation<Project> {}

    /// <summary>
    ///     Class ProjectService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Project}" />
    /// <seealso cref="TargetProcess.Services.IProjectService" />
    public class ProjectService : CrudService<Project>, IProjectService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public ProjectService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Projects";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Project dto)
            => dto.Name != null && dto.Company != null;

        /// <summary>
        ///     Undeletes the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;Project&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<Project> Undelete(Project model)
        {
            throw new NotImplementedException();
        }
    }
}