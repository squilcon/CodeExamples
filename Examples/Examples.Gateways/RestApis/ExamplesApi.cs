using Examples.Gateways.Models;
using System.Text;
using System.Text.Json;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make requests to the endpoints of the Examples Api
    /// </summary>
    internal class ExamplesApi : IExamplesApi
    {
        private readonly IEnvironmentVariables _environmentVariables;
        private readonly IAuthenticationApi _authenticationApi;
        private readonly IRestRequestLogging _restRequestLogging;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="environmentVariables">IEnvironmentVariables dependency</param>
        /// <param name="authenticationApi">IAuthenticationApi dependency</param>
        /// <param name="restRequestLogging">IRestRequestLogging dependency</param>
        public ExamplesApi(IEnvironmentVariables environmentVariables,
                           IAuthenticationApi authenticationApi,
                           IRestRequestLogging restRequestLogging)
        {
            _environmentVariables = environmentVariables;
            _authenticationApi = authenticationApi;
            _restRequestLogging = restRequestLogging;
        }

        /// <summary>
        /// Base uri of the Api
        /// </summary>
        private Uri ApiUri => new(_environmentVariables.BaseUri, "/examples/base/path/");

        /// <inheritdoc/>
        public async Task<Token> GetTokenAsync()
        {
            var authenticationUri = new Uri(_environmentVariables.BaseUri, "/token/generation/endpoint");
            return await _authenticationApi.GetTokenAsync(authenticationUri.AbsoluteUri,
                                                          "examples.grant.type",
                                                          _environmentVariables.ClientId,
                                                          _environmentVariables.ClientSecret,
                                                          _environmentVariables.Username,
                                                          _environmentVariables.Password,
                                                          "examples.scope");
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostExamplesAsync(Token requestToken, string exampleContent, Uri apiUri)
        {
            var requestContent = new StringContent(JsonSerializer.Serialize(exampleContent), Encoding.UTF8, "application/json");
            return await _restRequestLogging.PostAsync(requestToken.AccesToken, requestContent, apiUri, "examples/post/endpoint");
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostExamplesAsync(Token requestToken, string exampleContent)
        {
            return await PostExamplesAsync(requestToken, exampleContent, ApiUri);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetExamplesAsync(Token requestToken, string exampleContent, Uri apiUri)
        {
            var endpoint = $"examples/get/endpoint?examples={exampleContent}";
            return await _restRequestLogging.GetAsync(requestToken.AccesToken, apiUri, endpoint);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetExamplesAsync(Token requestToken, string exampleContent)
        {
            return await GetExamplesAsync(requestToken, exampleContent, ApiUri);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteExamplesAsync(Token requestToken, string exampleContent, Uri apiUri)
        {
            var endpoint = $"examples/delete/endpoint?examples={exampleContent}";
            return await _restRequestLogging.DeleteAsync(requestToken.AccesToken, apiUri, endpoint);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteExamplesAsync(Token requestToken, string exampleContent)
        {
            return await DeleteExamplesAsync(requestToken, exampleContent, ApiUri);
        }
    }
}
