using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using TargetProcess.Data.Dto;
using TargetProcess.Response;

namespace TargetProcess.Base
{
    public interface IRestApiService : IRestServiceUrl
    {
        Task<T> SendPostRequest<T>(T payload);
        Task<T> GetEntityById<T>(int id);
        Task<IEnumerable<T>> SendGetRequest<T>(string parameters);
        Task<DeleteResponse> SendDeleteRequest<T>(T @object) where T : ITargetProcessDto;
        Task<DeleteResponse> SendDeleteRequest(int id);
    }

    public abstract class RestApiService : IRestApiService
    {
        /// <summary>
        ///     Gets the request handler.
        /// </summary>
        /// <value>The request handler.</value>
        protected IServiceRequestHandler RequestHandler { get; }

        protected RestApiService(IServiceRequestHandler requestHandler)
        {
            RequestHandler = requestHandler;
        }

        /// <summary>
        ///     Gets the entity URL.
        /// </summary>
        /// <value>The entity URL.</value>
        public abstract string EntityUrl { get; }

        /// <summary>
        ///     Gets the API base URL.
        /// </summary>
        /// <value>The API base URL.</value>
        public string ApiBaseUrl { get; } = "api";

        /// <summary>
        ///     Gets the API version.
        /// </summary>
        /// <value>The API version.</value>
        public int ApiVersion { get; } = ServiceSettings.Default.api_version < 1
            ? 1
            : ServiceSettings.Default.api_version;

        /// <summary>
        ///     Sends a delete request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object">The object.</param>
        /// <returns>Task&lt;IRestResponse&gt;.</returns>
        /// <exception cref="System.NullReferenceException"></exception>
        public virtual async Task<DeleteResponse> SendDeleteRequest<T>(T @object) where T : ITargetProcessDto
        {
            if (!@object.Id.HasValue) throw new NullReferenceException("The Id of the object must be set");

            return await SendDeleteRequest(@object.Id.Value);
        }

        /// <summary>
        ///     Sends a delete request based on the id of an object
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;IRestResponse&gt;.</returns>
        public async Task<DeleteResponse> SendDeleteRequest(int id) =>
            await RequestHandler.ExecuteDeleteAsync(id, ToString());

        /// <summary>
        ///     Sends a post request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="payload">The payload.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public virtual async Task<T> SendPostRequest<T>(T payload)
            => await RequestHandler.ExecutePostAsync(payload, ToString());

        /// <summary>
        ///     Sends a get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">The identifier.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public virtual async Task<T> GetEntityById<T>(int id)
            => await RequestHandler.ExecuteGetAsync<T>($@"{ToString()}/{id}");

        /// <summary>
        ///     Sends the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        public async Task<IEnumerable<T>> SendGetRequest<T>(string parameters)
            => await RequestHandler.ExecuteFilteredGet<T>(parameters);

        /// <summary>
        ///     Sends the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        public async Task<IEnumerable<T>> SendGetRequest<T>(Predicate<T> filterPredicate)
            => await RequestHandler.ExecuteFilteredGet(filterPredicate);

        /// <summary>
        ///     Returns the url of the service in .
        /// </summary>
        public override string ToString() => $@"{ApiBaseUrl}/v{ApiVersion}/{EntityUrl}";
    }
}