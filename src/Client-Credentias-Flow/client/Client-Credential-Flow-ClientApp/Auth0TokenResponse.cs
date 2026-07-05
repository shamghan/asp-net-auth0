using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Client_Credential_Flow_ClientApp
{
    public class Auth0TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; init; } = null!;

        [JsonPropertyName("token_type")]
        public string TokenType { get; init; } = null!;

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; init; }
    }
}
