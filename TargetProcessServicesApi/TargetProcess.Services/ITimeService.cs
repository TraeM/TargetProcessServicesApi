using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface ITimeService : ICrudService<Time>, IRestApiService,
                                    ITargetProcessRequirmentsValidation<Time> {}

    /// <summary>
    /// Class TimeService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Time}" />
    /// <seealso cref="TargetProcess.Services.ITimeService" />
    public class TimeService : CrudService<Time>, ITimeService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeService"/> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public TimeService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        /// Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Times";

        /// <summary>
        /// Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Time dto) =>
            dto.Project != null && dto.Description != null && dto.User != null;
    }
}