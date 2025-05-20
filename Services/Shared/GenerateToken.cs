using System.Text;
using System.Text.Json;
using Wirex_POC.Services.Models;

namespace Wirex_POC.Services.Shared
{
    public class GenerateToken
    {

        private readonly ApiRequest _apiRequest;

        public GenerateToken()
        {
            _apiRequest = new ApiRequest();
        }

        private static readonly JsonSerializerOptions CachedJsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Ensure consistent casing
        };

        public async Task<string?> GetAccessToken()
        { 
            var tokenUrl = "https://wirex-pay-dev.eu.auth0.com/oauth/token";
            var requestData = new
            {
                client_id = "Gt3jDgpqE4UApbjFcof4q0aaG4ihXglU",
                client_secret = "U6XaAAYOxdPuH3vSqhxEKtgnXZZuGIXqf_WOG9QrbZeGd372TIJC1GcTyokdXRY3",
                audience = "https://api-business.wirexpaychain.tech",
                grant_type = "client_credentials"
            };

            var finalPayload = JsonSerializer.Serialize(requestData, CachedJsonSerializerOptions);

            var response = await _apiRequest.SendPostRequestAsync<Auth0TokenResponse>(tokenUrl, finalPayload);
                   
            var accessToken = response?.TokenType + " " + response?.AccessToken;
            return accessToken;
        }
    }
}
