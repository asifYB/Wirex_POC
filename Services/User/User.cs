using System.Text.Json;
using Wirex_POC.Services.Models;
using Wirex_POC.Services.Shared;

namespace Wirex_POC.Services.User
{
    public class User
    {

        private readonly ApiRequest _apiRequest;

        public User() { 
           _apiRequest = new ApiRequest();
        }

        private static readonly JsonSerializerOptions CachedJsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Ensure consistent casing
        };

        public async Task CreateUser(string accessToken)
        {
            string url = "https://api-business.wirexpaychain.tech/api/v1/user";
            var client = new HttpClient();
            var headers = new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "X-Chain-Id", "84532" },
                { "Authorization",  accessToken}
            };

            // Request body
            var requestBody = new
            {
                email = "mohdasifreal@gmail.com",
                country = "IN",
                wallet_address = "0xb01E5e4659023f6d405976d7246c397bF5F06DDc" // my from address i used
            };

            var finalPayload = JsonSerializer.Serialize(requestBody, CachedJsonSerializerOptions);
            
            await _apiRequest.SendPostRequestAsync<Auth0TokenResponse>(url, finalPayload, headers);

        }
    }
}
