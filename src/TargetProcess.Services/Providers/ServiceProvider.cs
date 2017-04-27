using TargetProcess.Core.DependancyInjection;

namespace TargetProcess.Providers
{
    /// <summary>
    ///     Interface IServiceProvider.
    /// </summary>
    /// <remarks>
    ///     When inheriting from this interface, you should inherit from <see cref="IocContainer" />
    ///     so that the Register method is called on the initialization of the IocContainer.
    /// </remarks>
    public interface IServiceProvider
    {
        IServiceRequestHandler RequestHandler { get; }
        void Register();
    }

    /// <summary>
    ///     Class ServiceProvider. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="IocContainer" />
    /// <seealso cref="IServiceProvider" />
    public sealed class ServiceProvider : IocContainer, IServiceProvider
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServiceProvider" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public ServiceProvider(IServiceRequestHandler requestHandler)
        {
            RequestHandler = requestHandler;
        }

        /// <summary>
        ///     Gets the request handler.
        /// </summary>
        /// <value>The request handler.</value>
        public IServiceRequestHandler RequestHandler { get; }

        /// <summary>
        ///     Registers service instances.
        /// </summary>
        public override void Register()
        {
            Register<ICompanyService, CompanyService>(() => new CompanyService(RequestHandler));
            Register<IProgramService, ProgramService>(() => new ProgramService(RequestHandler));
            Register<IProjectService, ProjectService>(() => new ProjectService(RequestHandler));
            Register<IEpicService, EpicService>(() => new EpicService(RequestHandler));
            Register<IFeatureService, FeatureService>(() => new FeatureService(RequestHandler));
            Register<IRequestService, RequestService>(() => new RequestService(RequestHandler));
            Register<ICommentService, CommentService>(() => new CommentService(RequestHandler));
            Register<ITaskService, TaskService>(() => new TaskService(RequestHandler));
            Register<IBugService, BugService>(() => new BugService(RequestHandler));
            Register<ITimeService, TimeService>(() => new TimeService(RequestHandler));
            Register<IUserStoryService, UserStoryService>(() => new UserStoryService(RequestHandler));

            //Register<ICustomFieldService, CustomFieldService>();
            //Register<IPriorityService, PriorityService>();
            //Register<IRoleService, RoleService>();
            //Register<IUserService, UserService>();
        }
    }
}