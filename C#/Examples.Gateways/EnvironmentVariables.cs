using Examples.Gateways.Constants;
using Microsoft.Extensions.Configuration;

namespace Examples.Gateways
{
    /// <summary>
    /// Environment variables used
    /// </summary>
    internal class EnvironmentVariables : IEnvironmentVariables
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration">IConfiguration dependency</param>
        public EnvironmentVariables(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <inheritdoc/>
        public Uri BaseUri => GetValue<Uri>(EnvirKeys.BaseUri);

        /// <inheritdoc/>
        public string ClientId => GetValue<string>(EnvirKeys.ClientId);

        /// <inheritdoc/>
        public string ClientSecret => GetValue<string>(EnvirKeys.ClientSecret);

        /// <inheritdoc/>
        public string Username => GetValue<string>(EnvirKeys.Username);

        /// <inheritdoc/>
        public string Password => GetValue<string>(EnvirKeys.Password);

        /// <summary>
        /// Obtain the value of the environment variable
        /// </summary>
        /// <typeparam name="T">The type that needs to be returned</typeparam>
        /// <param name="environmentVariableName">The name of the environment variable</param>
        /// <returns>The value of the environment variable</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private T GetValue<T>(string environmentVariableName)
        {
            if (string.IsNullOrWhiteSpace(environmentVariableName))
            {
                throw new ArgumentNullException(environmentVariableName);
            }

            return _configuration.GetValue<T>(environmentVariableName);
        }
    }
}
