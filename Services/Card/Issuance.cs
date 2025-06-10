using System.Text.Json;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Wirex_POC.Services.Issuance
{
    public class Issuance
    {
        public static async Task IssuePlasticCard(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/plastic";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
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
                card_name = "My Wirex Card",
                delivery_address = new
                {
                    city = "London",
                    country = "UK",
                    line1 = "221B Baker Street",
                    line2 = "Flat 2",
                    state = "Greater London",
                    zip_code = "NW1 6XE"
                },
                delivery_provider = "DHL",
                name_on_card = "Mohammad Asif",
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task IssueVirtualCard(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/cards/virtual";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization", accessToken },
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifsp21@gmail.com" }
                }
            };

            var payload = new
            {
                card_name = "My Wirex Card",
                name_on_card = "Mohammad Asif",
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task ActivateCard(string accessToken, string cardId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/activate";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
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
                card_number_last4 = "1234",
                expiry_date = "12/2022"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

    }
}
