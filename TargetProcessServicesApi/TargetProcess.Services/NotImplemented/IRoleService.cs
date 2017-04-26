using System;

using TargetProcess.Base;
using TargetProcess.Data.Dto;

namespace TargetProcess
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