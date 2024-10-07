namespace Examples.Gateways
{
    /// <summary>
    /// Environment variables used
    /// </summary>
    internal interface IEnvironmentVariables
    {
        /// <summary>
        /// Base Uri
        /// </summary>
        Uri BaseUri { get; }

        /// <summary>
        /// Client Id
        /// </summary>
        string ClientId { get; }

        /// <summary>
        /// Client Secret
        /// </summary>
        string ClientSecret { get; }

        /// <summary>
        /// Password
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Username
        /// </summary>
        string Username { get; }
    }
}