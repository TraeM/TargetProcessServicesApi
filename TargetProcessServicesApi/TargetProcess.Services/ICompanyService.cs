using TargetProcess.Services.Base;
using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services
{
    public interface ICompanyService : ICrudService<Company>, IRestApiService,
                                       ITargetProcessRequirmentsValidation<Company> {}

    /// <summary>
    ///     Class CompanyService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Company}" />
    /// <seealso cref="TargetProcess.Services.ICompanyService" />
    public class CompanyService : CrudService<Company>, ICompanyService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CompanyService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public CompanyService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Companies";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Company dto)
            => dto.Name != null;
    }
}