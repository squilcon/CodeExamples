using Examples.Gateways.Models;
using System.Text.Json;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make request to the Authentication Api
    /// </summary>
    internal class AuthenticationApi : IAuthenticationApi
    {
        private readonly IRestRequestLogging _restRequestLogging;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restRequestLogging">IRestRequestLogging dependency</param>
        public AuthenticationApi(IRestRequestLogging restRequestLogging)
        {
            _restRequestLogging = restRequestLogging;
        }

        /// <inheritdoc/>
        public async Task<Token> GetTokenAsync(string url, HttpContent content)
        {
            var response = await _restRequestLogging.PostAsync(url, content);
            var resultString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<Token>(resultString) ?? new Token();
        }

        /// <inheritdoc/>
        public async Task<Token> GetTokenAsync(string url, string grantType, string clientId, string clientSecret, string username, string password, string scope)
        {
            var requestBody = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", grantType),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("scope", scope)
            }); ;

            return await GetTokenAsync(url, requestBody);
        }
    }
}
