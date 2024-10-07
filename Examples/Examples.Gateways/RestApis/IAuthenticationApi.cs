using Examples.Gateways.Models;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make request to the Authentication Api
    /// </summary>
    public interface IAuthenticationApi
    {
        /// <summary>
        /// Get an access token
        /// </summary>
        /// <param name="url">Authentication url used to generate the token</param>
        /// <param name="content">The content needed for the token generation</param>
        /// <returns>The information of the token</returns>
        Task<Token> GetTokenAsync(string url, HttpContent content);

        /// <summary>
        /// Get an access token
        /// </summary>
        /// <param name="url">Authentication url used to generate the token</param>
        /// <param name="grantType">The grant type</param>
        /// <param name="clientId">The client Id</param>
        /// <param name="clientSecret">The client secret</param>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <param name="scope">The scope</param>
        /// <returns>The information of the token</returns>
        Task<Token> GetTokenAsync(string url, string grantType, string clientId, string clientSecret, string username, string password, string scope);
    }
}