using System.Threading.Tasks;

using TargetProcess.Services.Data.Dto;
using TargetProcess.Services.Exceptions;
using TargetProcess.Services.Response;

namespace TargetProcess.Services.Base
{
    public interface ICrudService<T> where T : ITargetProcessDto
    {
        T CreateSynchronously(T model);
        Task<T> Create(T model);
        Task<T> Update(T model);
        Task<DeleteResponse> Delete(T model);
    }

    /// <summary>
    ///     Class CrudService.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="TargetProcess.Services.Base.RestApiService " />
    /// <seealso cref="TargetProcess.Services.Base.ICrudService{T}" />
    public abstract class CrudService<T> : RestApiService, ICrudService<T> where T : ITargetProcessDto
    {
        public abstract override string EntityUrl { get; }

        protected CrudService(IServiceRequestHandler requestHandler) : base(requestHandler) {}

        /// <summary>
        ///     Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        /// <exception cref="TargetProcessServiceCreateEntityException">Unable to create an entity with the Id property set</exception>
        public virtual async Task<T> Create(T model)
        {
            if (model.Id.HasValue)
                throw new TargetProcessServiceCreateEntityException(
                    "Unable to create an entity with the Id property set");

            var response = SendPostRequest(model);
            return await response;
        }

        /// <summary>
        ///     Updates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        /// <exception cref="TargetProcessServiceCreateEntityException">Unable to update an entity with out the Id property set</exception>
        public virtual async Task<T> Update(T model)
        {
            if (!model.Id.HasValue)
                throw new TargetProcessServiceCreateEntityException(
                    "Unable to update an entity with out the Id property set");

            var response = SendPostRequest(model);
            return await response;
        }

        /// <summary>
        ///     Deletes the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;DeleteResponse&gt;.</returns>
        /// <exception cref="TargetProcessServiceCreateEntityException">Unable to delete an entity with out the Id property set</exception>
        public virtual async Task<DeleteResponse> Delete(T model)
        {
            if (!model.Id.HasValue)
                throw new TargetProcessServiceCreateEntityException(
                    "Unable to delete an entity with out the Id property set");

            return await SendDeleteRequest(model);
        }

        /// <summary>
        ///     Creates the model synchronously.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>T.</returns>
        public T CreateSynchronously(T model) => Create(model).Result;
    }
}