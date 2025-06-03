using Microsoft.AspNetCore.Authentication.OAuth;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Wirex_POC.Services.Shared
{
    public class ApiRequest
    {

        private readonly HttpClient _httpClient;

        public ApiRequest(HttpClient? httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
        }

        private static readonly JsonSerializerOptions CachedJsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Ensure consistent casing
        };


        public async Task<T?> SendPostRequestAsync<T>(string tokenUrl, string jsonPayload, Dictionary<string, string>? headers = null)
        {
            StringContent stringContent = null;

            if (jsonPayload != null)
            {
                stringContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            }

            if(headers is not null)
            {
                foreach (var header in headers)
                {
                    _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            var response = await _httpClient.PostAsync(tokenUrl, stringContent);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(responseBody))
            {
                var responseJson = JsonSerializer.Deserialize<T>(responseBody, CachedJsonSerializerOptions);
                return responseJson!;
            }

            return default;
        }
    }
}
