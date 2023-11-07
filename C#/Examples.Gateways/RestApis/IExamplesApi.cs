using Examples.Gateways.Constants;
using Examples.Gateways.Models;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make requests to the endpoints of the Examples Api
    /// </summary>
    public interface IExamplesApi
    {
        /// <summary>
        /// Make a request to delete something
        /// <para/>
        /// To use this function, you need to have setup the following environment variable :
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.BaseUri"/>
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteExamplesAsync(Token requestToken, string exampleContent);

        /// <summary>
        /// Make a request to delete something
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <param name="apiUri">The Api Uri</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> DeleteExamplesAsync(Token requestToken, string exampleContent, Uri apiUri);

        /// <summary>
        /// Make a request to get something
        /// <para/>
        /// To use this function, you need to have setup the following environment variable :
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.BaseUri"/>
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> GetExamplesAsync(Token requestToken, string exampleContent);

        /// <summary>
        /// Make a request to get something
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <param name="apiUri">The Api Uri</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> GetExamplesAsync(Token requestToken, string exampleContent, Uri apiUri);

        /// <summary>
        /// Get the token used for making request to the "Examples Api"
        /// <para/>
        /// To use this function, you need to have setup the following environment variable :
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.BaseUri"/>
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.ClientId"/>
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.ClientSecret"/>
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.Password"/>
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.Username"/>
        /// </summary>
        /// <returns>The token information</returns>
        Task<Token> GetTokenAsync();

        /// <summary>
        /// Make a request to post something
        /// <para/>
        /// To use this function, you need to have setup the following environment variable :
        /// <para/>
        /// <inheritdoc cref="EnvirKeys.BaseUri"/>
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> PostExamplesAsync(Token requestToken, string exampleContent);

        /// <summary>
        /// Make a request to post something
        /// </summary>
        /// <param name="requestToken">The token</param>
        /// <param name="exampleContent">The content</param>
        /// <param name="apiUri">The Api Uri</param>
        /// <returns>The response of the request</returns>
        Task<HttpResponseMessage> PostExamplesAsync(Token requestToken, string exampleContent, Uri apiUri);
    }
}