using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface IEpicService : IRestApiService, ICrudService<Epic>, ITargetProcessRequirmentsValidation<Epic> {}

    /// <summary>
    /// Class EpicService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Epic}" />
    /// <seealso cref="TargetProcess.Services.IEpicService" />
    public class EpicService : CrudService<Epic>, IEpicService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpicService"/> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public EpicService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        /// Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Epics";

        /// <summary>
        /// Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Epic dto)
            => dto.Name != null && dto.Project != null;
    }
}