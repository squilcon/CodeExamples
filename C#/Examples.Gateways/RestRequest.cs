namespace Examples.Gateways
{
    /// <summary>
    /// Simplify making HTTP request for REST API
    /// </summary>
    internal class RestRequest : IRestRequest
    {
        private readonly IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpClientFactory">IHttpClientFactory dependency</param>
        public RestRequest(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            foreach (var header in requestHeaders)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            return await client.PostAsync(requestUri, requestContent);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint)
        {
            var headers = AddBearerToken(bearerToken);
            var requestUri = FormatUri(apiBaseUri, endpoint);
            return await PostAsync(requestUri, requestContent, headers);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string requestUrl, HttpContent requestContent)
        {
            return await PostAsync(new Uri(requestUrl), requestContent, new Dictionary<string, string>());
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, IDictionary<string, string> requestHeaders)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            foreach (var header in requestHeaders)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            return await client.GetAsync(requestUri);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(string bearerToken, Uri apiBaseUri, string endpoint)
        {
            var headers = AddBearerToken(bearerToken);
            var requestUri = FormatUri(apiBaseUri, endpoint);
            return await GetAsync(requestUri, headers);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, IDictionary<string, string> requestHeaders)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            foreach (var header in requestHeaders)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            return await client.DeleteAsync(requestUri);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, HttpContent requestContent, IDictionary<string, string> requestHeaders)
        {
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            foreach (var header in requestHeaders)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            var request = new HttpRequestMessage()
            {
                Content = requestContent,
                Method = HttpMethod.Delete,
                RequestUri = requestUri
            };

            //DeleteAsync can't pass a body by default. So, we need to do it another way when that situation happens.
            return await client.SendAsync(request);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string bearerToken, Uri apiBaseUri, string endpoint)
        {
            var headers = AddBearerToken(bearerToken);
            var requestUri = FormatUri(apiBaseUri, endpoint);
            return await DeleteAsync(requestUri, headers);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string bearerToken, HttpContent requestContent, Uri apiBaseUri, string endpoint)
        {
            var headers = AddBearerToken(bearerToken);
            var requestUri = FormatUri(apiBaseUri, endpoint);
            return await DeleteAsync(requestUri, requestContent, headers);
        }

        /// <summary>
        /// Format an Uri by making sure that all parts are include
        /// </summary>
        /// <param name="baseUriAndPath">Base Uri who can contain additionnal segments</param>
        /// <param name="relativePath">Relative path who will be added to the base Uri</param>
        /// <returns>The formatted Uri</returns>
        private static Uri FormatUri(Uri baseUriAndPath, string relativePath)
        {
            //If the base Uri ends with a slash and the relative path starts without a slash,
            //the combination of the two keeps all parts / segments when using the Uri constructor.
            if (!baseUriAndPath.ToString().EndsWith("/"))
            {
                baseUriAndPath = new Uri($"{baseUriAndPath}/");
            }

            return new Uri(baseUriAndPath, relativePath.TrimStart('/'));
        }

        /// <summary>
        /// Add the bearer token to a dictionnary for the headers
        /// </summary>
        /// <param name="bearerToken">The bearer token</param>
        /// <returns>A dictionnary</returns>
        private static Dictionary<string, string> AddBearerToken(string bearerToken)
        {
            return new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {bearerToken}" }
            };
        }
    }
}
