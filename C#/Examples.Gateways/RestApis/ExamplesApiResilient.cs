using Examples.Gateways.Models;
using Polly;
using System.Text.Json;

namespace Examples.Gateways.RestApis
{
    /// <summary>
    /// Make resilient requests to the endpoints of the Examples Api
    /// </summary>
    internal class ExamplesApiResilient : IExamplesApiResilient
    {
        private readonly IExamplesApi _examplesApi;
        private Token _token;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="examplesApi">IExamplesApi dependency</param>
        public ExamplesApiResilient(IExamplesApi examplesApi)
        {
            _examplesApi = examplesApi;
            _token = new Token();
        }

        /// <inheritdoc/>
        public async Task<int> PostExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2)
        {
            return await ResilientRequest<int>(() => _examplesApi.PostExamplesAsync(_token, exampleContent), maxRetry, maxWaitInSeconds);
        }

        /// <inheritdoc/>
        public async Task<int> GetExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2)
        {
            return await ResilientRequest<int>(() => _examplesApi.GetExamplesAsync(_token, exampleContent), maxRetry, maxWaitInSeconds);
        }

        /// <inheritdoc/>
        public async Task<int> DeleteExamplesAsync(string exampleContent, int maxRetry = 2, int maxWaitInSeconds = 2)
        {
            return await ResilientRequest<int>(() => _examplesApi.DeleteExamplesAsync(_token, exampleContent), maxRetry, maxWaitInSeconds);
        }

        /// <summary>
        /// Make a call to a function that makes a request to an endpoint of the Api while making the request resilient
        /// </summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="requestFunction">The function to call</param>
        /// <param name="maxRetry">The maximum number of retry</param>
        /// <param name="maxWaitInSeconds">The maximum number of seconds to wait</param>
        /// <returns>The result of the function call</returns>
        private async Task<T> ResilientRequest<T>(Func<Task<HttpResponseMessage>> requestFunction, int maxRetry = 2, int maxWaitInSeconds = 2) where T : new()
        {
            var result = new T();
            var retryPolicy = Policy.Handle<HttpRequestException>().WaitAndRetryAsync(maxRetry, i => TimeSpan.FromSeconds(maxWaitInSeconds));
            await retryPolicy.ExecuteAsync(async () =>
            {
                if (string.IsNullOrWhiteSpace(_token.AccesToken))
                {
                    _token = await _examplesApi.GetTokenAsync();
                }
                var response = await requestFunction();
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch
                {
                    _token = new Token();
                    throw;
                }

                var responseMessage = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<T>(responseMessage);
            });

            return result;
        }
    }
}
