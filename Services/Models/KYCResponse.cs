using System.Text.Json.Serialization;

namespace Wirex_POC.Services.Models
{
    public class KYCResponse
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

    }
}
