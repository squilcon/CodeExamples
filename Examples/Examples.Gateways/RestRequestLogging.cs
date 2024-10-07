using Microsoft.Extensions.Logging;

namespace Examples.Gateways
{
    /// <summary>
    /// Simplify making HTTP request for REST API while logging the requests and responses
    /// </summary>
    internal class RestRequestLogging : IRestRequestLogging
    {
        private readonly IRestRequest _restRequest;
        private readonly ILogger<RestRequestLogging> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restRequest">IRestRequest dependency</param>
        /// <param name="logger">ILogger dependency</param>
        public RestRequestLogging(IRestRequest restRequest,
                                  ILogger<RestRequestLogging> logger)
        {
            _restRequest = restRequest;
            _logger = logger;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders)
        {
            var response = await _restRequest.PostAsync(requestUri, requestContent, requestHeaders);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint)
        {
            var response = await _restRequest.PostAsync(bearerToken, requestContent, apiBaseUri, endpoint);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent requestContent)
        {
            var response = await _restRequest.PostAsync(requestUrl, requestContent);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, IDictionary<string, string> requestHeaders)
        {
            var response = await _restRequest.GetAsync(requestUri, requestHeaders);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(string bearerToken, Uri apiBaseUri, string endpoint)
        {
            var response = await _restRequest.GetAsync(bearerToken, apiBaseUri, endpoint);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, IDictionary<string, string> requestHeaders)
        {
            var response = await _restRequest.DeleteAsync(requestUri, requestHeaders);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders)
        {
            var response = await _restRequest.DeleteAsync(requestUri, requestContent, requestHeaders);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string bearerToken, Uri apiBaseUri, string endpoint)
        {
            var response = await _restRequest.DeleteAsync(bearerToken, apiBaseUri, endpoint);
            await LogResponseAsync(response);
            return response;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint)
        {
            var response = await _restRequest.DeleteAsync(bearerToken, requestContent, apiBaseUri, endpoint);
            await LogResponseAsync(response);
            return response;
        }

        /// <summary>
        /// Log the response and the request
        /// </summary>
        /// <param name="response">The response</param>
        private async Task LogResponseAsync(HttpResponseMessage response)
        {
            _logger.LogTrace("Request: {request}", response.RequestMessage);
            if (response.RequestMessage?.Content != null)
            {
                _logger.LogTrace("{requestContent}", await response.RequestMessage.Content.ReadAsStringAsync());
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                _logger.LogTrace("Response: {responseConent}", responseContent);
            }
            else
            {
                _logger.LogError("Response: {responseConent}", responseContent);
            }
        }
    }
}
