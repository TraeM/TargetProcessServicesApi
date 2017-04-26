using TargetProcess.Services.Base;
using TargetProcess.Services.Data.Dto;

namespace TargetProcess.Services
{
    public interface ICommentService : ICrudService<Comment>, IRestApiService,
                                       ITargetProcessRequirmentsValidation<Comment> {}

    /// <summary>
    ///     Class CommentService.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.Base.CrudService{TargetProcess.Data.Models.Comment}" />
    /// <seealso cref="TargetProcess.Services.ICommentService" />
    public class CommentService : CrudService<Comment>, ICommentService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CommentService" /> class.
        /// </summary>
        /// <param name="requestHandler">The request handler.</param>
        public CommentService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public override string EntityUrl { get; } = "Comments";

        /// <summary>
        ///     Validates Target Process service requirments.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns><c>true</c> If object meets Target Process' requirments for api interaction <c>false</c> otherwise.</returns>
        public bool MeetsServiceRequirments(Comment dto)
            => dto.General != null && dto.Description != null;
    }
}