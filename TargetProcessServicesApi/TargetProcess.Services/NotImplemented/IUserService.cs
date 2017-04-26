using System;

using TargetProcess.Data.Models;
using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface IUserService : ITargetProcessRequirmentsValidation<User> {}

    [Obsolete("Not currently being used")]
    public class UserService : RestApiService, IUserService
    {
        public override string EntityUrl { get; } = "Users";

        public UserService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        public bool MeetsServiceRequirments(User dto)
            => dto.Email != null && dto.Login != null && dto.Password != null && dto.FirstName != null &&
               dto.LastName != null;
    }
}