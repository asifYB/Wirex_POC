using System.Text.Json;
using System.Text;
using System.Collections.Generic;

namespace Wirex_POC.Services.Issuance
{
    public class Management
    {
        public static async Task BlockCard(string accessToken, string cardId)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/block";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                }
            };

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task CLoseCard(string accessToken, string cardId)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/close";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                }
            };

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }



        public static async Task ChangeCardLimit(string accessToken, string cardId)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/limit";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                }
            };

            var payload = new
            {
                limit = "1000"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

        public static async Task ChangeCardName(string accessToken, string cardId)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/name";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                }
            };

            var payload = new
            {
                name = "new_card_name"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

        public static async Task UnBlockCard(string accessToken, string cardId)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/unblock";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                }
            };

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
