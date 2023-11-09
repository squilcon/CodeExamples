using Examples.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace Examples.Services
{
    /// <summary>
    /// Offer header fonctionalities
    /// </summary>
    internal class HeaderServices : IHeaderServices
    {
        /// <inheritdoc/>
        public string GetBearerTokenFromHeader(HttpRequest request)
        {
            var token = string.Empty;
            var header = request.Headers.FirstOrDefault(x => x.Key.Equals("Authorization"));
            if (header.Key != null)
            {
                var authHeader = AuthenticationHeaderValue.Parse(header.Value);
                if (authHeader.Scheme.Equals("Bearer"))
                {
                    token = authHeader.Parameter;
                }
            }

            return token ?? string.Empty;
        }
    }
}
