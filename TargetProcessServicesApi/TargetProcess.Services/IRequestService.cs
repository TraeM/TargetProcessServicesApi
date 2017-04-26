using TargetProcess.Services.Base;
using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services
{
    public interface IRequestService : ICrudService<Request>, IRestApiService,
                                       ITargetProcessRequirmentsValidation<Request> {}

    /// <summary>
    ///     Class RequestService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Request}" />
    /// <seealso cref="TargetProcess.Services.IRequestService" />
    public class RequestService : CrudService<Request>, IRequestService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RequestService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public RequestService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Requests";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Request dto)
            => dto.Name != null && dto.Project != null && dto.EntityState != null;
    }
}