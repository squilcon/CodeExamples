using Microsoft.AspNetCore.Http;

namespace Examples.Interfaces.Services
{
    /// <summary>
    /// Offer header fonctionalities
    /// </summary>
    public interface IHeaderServices
    {
        /// <summary>
        /// Get Bearer Token from header
        /// </summary>
        /// <param name="request">The request</param>
        /// <returns>The token or empty</returns>
        string GetBearerTokenFromHeader(HttpRequest request);
    }
}