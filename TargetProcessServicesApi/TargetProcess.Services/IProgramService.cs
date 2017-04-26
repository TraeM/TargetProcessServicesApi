using TargetProcess.Services.Base;
using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services
{
    public interface IProgramService : ICrudService<Program>, IRestApiService,
                                       ITargetProcessRequirmentsValidation<Program> {}

    /// <summary>
    ///     Class ProgramService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Program}" />
    /// <seealso cref="TargetProcess.Services.IProgramService" />
    public class ProgramService : CrudService<Program>, IProgramService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProgramService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public ProgramService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Programs";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Program dto) => dto.Name != null;
    }
}