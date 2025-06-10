using System.Text.Json;
using System.Text;

namespace Wirex_POC.Services.Card
{
    public class Details
    {
        public static async Task GetCardCVV(string accessToken, string cardId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/cvv";

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
                action_token = "e34356383-363377svd-47432883293293"  //action token can be retrieved through confirmation flow
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task GetCardDetails(string accessToken, string cardId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/details";

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
                action_token = "e34356383-363377svd-47432883293293"  //action token can be retrieved through confirmation flow
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task GetCardPin(string accessToken, string cardId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/{cardId}/details";

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
                action_token = "e34356383-363377svd-47432883293293"  //action token can be retrieved through confirmation flow
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
