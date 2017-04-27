using System;

using TargetProcess.Base;

namespace TargetProcess
{
    public interface IPriorityService {}

    [Obsolete("Not currently being used")]
    public class PriorityService : RestApiService, IPriorityService
    {
        public override string EntityUrl { get; } = "Priorities";

        public PriorityService(IServiceRequestHandler requestHandler) : base(requestHandler) {}
    }
}