using System.Text.Json;
using System.Text;
using System.Diagnostics.Metrics;

namespace Wirex_POC.Services.Card
{
    public class Fee
    {
        public static async Task GetOrderFees(string accessToken, string type, string country)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{type}/fees/{country}";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
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

        public static async Task CreateOrderFeeInvoice(string accessToken, string type, string country)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{type}/fees/{country}/payment";

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
                delivery_provider = "DHL",
                token_address = "0xA7E41d5680dE394EaA2ed417169DFf56840Fb3EE"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
