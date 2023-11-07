using System.Text.Json.Serialization;

namespace Examples.Gateways.Models
{
    /// <summary>
    /// Model / DTO of the json response of the Authentication Api
    /// </summary>
    public class Token
    {
        /// <summary>
        /// The access token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccesToken { get; set; } = string.Empty;

        /// <summary>
        /// The token type
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = string.Empty;

        /// <summary>
        /// Expires in how much time
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; } = string.Empty;

        /// <summary>
        /// The refresh token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;

        /// <summary>
        /// The scope
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; } = string.Empty;
    }
}
