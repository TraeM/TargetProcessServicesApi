using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface IBugService : ICrudService<Bug>, IRestApiService,
                                   ITargetProcessRequirmentsValidation<Bug> {}

    /// <summary>
    /// Class BugService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Bug}" />
    /// <seealso cref="TargetProcess.Services.IBugService" />
    public class BugService : CrudService<Bug>, IBugService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BugService"/> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public BugService(IServiceRequestHandler requestHandler) : base(requestHandler) { }

        /// <summary>
        /// Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Bugs";


        /// <summary>
        /// Meets the service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Bug dto) => dto.Name != null && dto.Project != null;
    }
}