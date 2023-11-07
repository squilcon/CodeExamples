namespace Examples.Gateways
{
    /// <summary>
    /// Simplify making HTTP request for REST API
    /// </summary>
    public interface IRestRequest
    {
        /// <summary>
        /// Make a DELETE request with bearer token in the headers and with content
        /// </summary>
        /// <param name="bearerToken">The bearer token</param>
        /// <param name="requestContent">The request content</param>
        /// <param name="apiBaseUri">Base uri of the api</param>
        /// <param name="endpoint">Endpoint of the api</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint);

        /// <summary>
        /// Make a DELETE request with bearer token in the headers
        /// </summary>
        /// <param name="bearerToken">The bearer token</param>
        /// <param name="apiBaseUri">Base uri of the api</param>
        /// <param name="endpoint">Endpoint of the api</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteAsync(string bearerToken, Uri apiBaseUri, string endpoint);

        /// <summary>
        /// Make a DELETE request with headers and content
        /// </summary>
        /// <param name="requestUri">The request Uri</param>
        /// <param name="requestContent">The request content</param>
        /// <param name="requestHeaders">The request headers</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders);

        /// <summary>
        /// Make a DELETE request with headers
        /// </summary>
        /// <param name="requestUri">The request Uri</param>
        /// <param name="requestHeaders">The request headers</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri, IDictionary<string, string> requestHeaders);

        /// <summary>
        /// Make a GET request with a bearer token in the headers
        /// </summary>
        /// <param name="bearerToken">The bearer token</param>
        /// <param name="apiBaseUri">Base uri of the api</param>
        /// <param name="endpoint">Endpoint of the api</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> GetAsync(string bearerToken, Uri apiBaseUri, string endpoint);

        /// <summary>
        /// Make a GET request with headers
        /// </summary>
        /// <param name="requestUri">The request Uri</param>
        /// <param name="requestHeaders">The request headers</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, IDictionary<string, string> requestHeaders);

        /// <summary>
        /// Make a POST request
        /// </summary>
        /// <param name="requestUrl">The request url</param>
        /// <param name="requestContent">The request content</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent requestContent);

        /// <summary>
        /// Make a POST request with bearer token in the headers
        /// </summary>
        /// <param name="bearerToken">The bearer token</param>
        /// <param name="requestContent">The request content</param>
        /// <param name="apiBaseUri">Base uri of the api</param>
        /// <param name="endpoint">Endpoint of the api</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> PostAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint);

        /// <summary>
        /// Make a POST request with headers
        /// </summary>
        /// <param name="requestUri">The request Uri</param>
        /// <param name="requestContent">The request content</param>
        /// <param name="requestHeaders">The request headers</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders);
    }
}