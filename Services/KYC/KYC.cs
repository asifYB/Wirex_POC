using System.Text.Json;
using Wirex_POC.Services.Models;
using Wirex_POC.Services.Shared;

namespace Wirex_POC.Services.KYC
{
    public class KYC
    {

        private readonly ApiRequest _apiRequest;

        public KYC()
        {
            _apiRequest = new ApiRequest();
        }

        private static readonly JsonSerializerOptions CachedJsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Ensure consistent casing
        };


        public async Task<string> GenerateSharingToken(string accessToken, string sumsub_client_id)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user/sharing-token";
            var headers = new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "Authorization",  accessToken},
                { "X-Chain-Id", "84532" },
                { "X-User-Email", "mohdasifreal@gmail.com" },
            };

            url = url + "?sumsub_client_id=" + sumsub_client_id;

            var response = await _apiRequest.SendPostRequestAsync<KYCResponse>(tokenUrl: url, jsonPayload: null, headers: headers);

            return response?.Token!;
        }

        public async Task<string> GenerateVerificationLink(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user/verification-link";
            var headers = new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "Authorization",  accessToken},
                { "X-Chain-Id", "84532" },
                { "X-User-Email", "mohdasifreal@gmail.com" },
            };

            var response = await _apiRequest.SendPostRequestAsync<KYCResponse>(tokenUrl: url, jsonPayload: null, headers: headers);

            return response?.RedirectUri!;

        }

        public async Task<string> GenerateVerificationToken(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user/verification-token";
            var headers = new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "Authorization",  accessToken},
                { "X-Chain-Id", "84532" },
                { "X-User-Email", "mohdasifreal@gmail.com" },
            };

            var response = await _apiRequest.SendPostRequestAsync<KYCResponse>(tokenUrl: url, jsonPayload: null, headers: headers);

            return response?.Token!;

        }
    }
}
