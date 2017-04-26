using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Security;
using System.Threading.Tasks;

using Newtonsoft.Json;

using RestSharp;
using RestSharp.Authenticators;

using TargetProcess.Services.Core.Extensions;
using TargetProcess.Services.Response;

namespace TargetProcess.Services
{
    public interface IServiceRequestHandler
    {
        string Username { get; }
        SecureString Password { get; }
        Uri TargetProcessBaseUri { get; }
        DataFormat DataFormat { get; }

        Task<DeleteResponse> ExecuteDeleteAsync(int id, string url);
        Task<T> ExecuteGetAsync<T>(string urlWithParams);
        Task<T> ExecutePostAsync<T>(T payload, string url);
        Task<IEnumerable<T>> ExecuteFilteredGet<T>(string parameters);
        Task<IEnumerable<T>> ExecuteFilteredGet<T>(Predicate<T> filterPredicate);
    }

    /// <summary>
    ///     Class ServiceRequestHandler.
    /// </summary>
    /// <seealso cref="TargetProcess.Services.IServiceRequestHandler" />
    public class ServiceRequestHandler : IServiceRequestHandler
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServiceRequestHandler" /> class.
        /// </summary>
        /// <param name="targetProcessBaseUri">The target process base URI.</param>
        /// <param name="username"></param>
        /// <param name="password">The password.</param>
        public ServiceRequestHandler(Uri targetProcessBaseUri, string username, SecureString password)
        {
            TargetProcessBaseUri = targetProcessBaseUri;
            Password = password;
            Username = username;
        }

        /// <summary>
        ///     Gets the target process base URI.
        /// </summary>
        /// <value>The target process base URI.</value>
        public Uri TargetProcessBaseUri { get; }

        /// <summary>
        ///     Gets the associated password for api usage.
        /// </summary>
        /// <value>The password.</value>
        public SecureString Password { get; }

        /// <summary>
        ///     Gets the associated username for api usage.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; }

        /// <summary>
        ///     Gets the data format.
        /// </summary>
        public DataFormat DataFormat { get; } = DataFormat.Xml;

        /// <summary>
        ///     execute delete as an asynchronous operation.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="url">The URL.</param>
        /// <returns>Task&lt;DeleteResponse&gt;.</returns>
        public async Task<DeleteResponse> ExecuteDeleteAsync(int id, string url)
        {
            var client = GetDefaultHttpClient();
            var request = CreateRequest(Method.DELETE, $@"{url}/{id}");
            return JsonConvert.DeserializeObject<DeleteResponse>((await client.ExecuteTaskAsync(request)).Content);
        }

        /// <summary>
        ///     execute post as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="payload">The payload.</param>
        /// <param name="url">The URL.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<T> ExecutePostAsync<T>(T payload, string url)
        {
            var client = GetDefaultHttpClient();
            var request = CreateRequest(Method.POST, url, payload);
            var response = await client.ExecutePostTaskAsync(request);
            return JsonConvert.DeserializeObject<T>(response?.Content);
        }

        /// <summary>
        ///     execute get as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="urlWithParams">The URL with parameters.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        public async Task<T> ExecuteGetAsync<T>(string urlWithParams)
        {
            var client = GetDefaultHttpClient();
            var request = new RestRequest(urlWithParams);
            return JsonConvert.DeserializeObject<T>((await client.ExecuteGetTaskAsync<T>(request)).Content);
        }

        /// <summary>
        ///     This method is not currently implemented. Scheduled for release two
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IEnumerable<T>> ExecuteFilteredGet<T>(string parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     This method is not currently implemented. Scheduled for release two
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filterPredicate">The filter predicate.</param>
        /// <returns>Task&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IEnumerable<T>> ExecuteFilteredGet<T>(Predicate<T> filterPredicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Creates the request.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="url">The URL.</param>
        /// <returns>IRestRequest.</returns>
        private IRestRequest CreateRequest(Method method, string url)
        {
            var restRequest = new RestRequest(url, method);
            restRequest.AddHeader("Content-Type", "application/xml; charset=utf-8");
            return restRequest;
        }

        /// <summary>
        ///     Creates the request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method">The method.</param>
        /// <param name="url">The URL.</param>
        /// <param name="payload">The payload.</param>
        /// <returns>IRestRequest.</returns>
        private IRestRequest CreateRequest<T>(Method method, string url, T payload)
        {
            var restRequest = new RestRequest(url, method);
            restRequest.AddHeader("Content-Type", "application/xml; charset=utf-8");
            restRequest.RequestFormat = DataFormat;
            if (!payload.Equals(default(T))) restRequest.AddBody(payload);
            return restRequest;
        }

        /// <summary>
        ///     Gets the default HTTP client.
        /// </summary>
        /// <returns>RestClient.</returns>
        [DebuggerHidden]
        private RestClient GetDefaultHttpClient()
        {
            var client = new RestClient(TargetProcessBaseUri)
            {
                Authenticator = new HttpBasicAuthenticator(Username, Password.ConvertToUnsecureString())
            };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            return client;
        }
    }
}