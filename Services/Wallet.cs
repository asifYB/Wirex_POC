using System.Text.Json;
using System.Text;

namespace Wirex_POC.Services
{
    public class Wallet
    {

        public static async Task GetWalletDeatil(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/wallet";

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
