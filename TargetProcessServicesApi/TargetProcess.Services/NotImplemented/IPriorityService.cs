using System;

using TargetProcess.Services.Base;

namespace TargetProcess.Services
{
    public interface IPriorityService {}

    [Obsolete("Not currently being used")]
    public class PriorityService : RestApiService, IPriorityService
    {
        public override string EntityUrl { get; } = "Priorities";

        public PriorityService(IServiceRequestHandler requestHandler) : base(requestHandler) {}
    }
}