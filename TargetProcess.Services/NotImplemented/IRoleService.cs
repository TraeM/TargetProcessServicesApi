using System;

using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface IRoleService : ITargetProcessRequirmentsValidation<Role> {}

    [Obsolete("Not currently being used")]
    public class RoleService : RestApiService, IRoleService
    {
        public override string EntityUrl { get; } = "Roles";

        public RoleService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        public bool MeetsServiceRequirments(Role dto) => dto.Name != null;
    }
}