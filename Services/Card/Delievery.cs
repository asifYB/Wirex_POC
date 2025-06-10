using System.Diagnostics.Metrics;

namespace Wirex_POC.Services.Card
{
    public class Delievery
    {
        public static async Task GetDelieveryCountries(string accessToken)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/delivery/countries";

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

        public static async Task GetDelieveryMethod(string accessToken, string country)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/cards/delivery/methods/{country}";

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


    }
}
