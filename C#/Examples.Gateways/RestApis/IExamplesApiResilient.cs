using Examples.Gateways.Constants;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make resilient requests to the endpoints of the Examples Api
    /// </summary>
    public interface IExamplesApiResilient
    {
        /// <summary>
        /// Make a call to the endpoint "ExamplesDelete". The token is obtain automatically and the request to the endpoint
        /// will be resent automatically if the response of the request is not a success.
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
        /// <param name="exampleContent">The content</param>
        /// <param name="maxRetry">The maximum number of retries</param>
        /// <param name="maxWaitInSeconds">The maximum number of seconds to wait between retries</param>
        /// <returns>The response result</returns>
        /// <exception cref="HttpRequestException"></exception>
        Task<int> DeleteExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2);

        /// <summary>
        /// Make a call to the endpoint "ExamplesGet". The token is obtain automatically and the request to the endpoint
        /// will be resent automatically if the response of the request is not a success.
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
        /// <param name="exampleContent">The content</param>
        /// <param name="maxRetry">The maximum number of retries</param>
        /// <param name="maxWaitInSeconds">The maximum number of seconds to wait between retries</param>
        /// <returns>The response result</returns>
        /// <exception cref="HttpRequestException"></exception>
        Task<int> GetExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2);

        /// <summary>
        /// Make a call to the endpoint "ExamplesPost". The token is obtain automatically and the request to the endpoint
        /// will be resent automatically if the response of the request is not a success.
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
        /// <param name="exampleContent">The content</param>
        /// <param name="maxRetry">The maximum number of retries</param>
        /// <param name="maxWaitInSeconds">The maximum number of seconds to wait between retries</param>
        /// <returns>The response result</returns>
        /// <exception cref="HttpRequestException"></exception>
        Task<int> PostExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2);
    }
}