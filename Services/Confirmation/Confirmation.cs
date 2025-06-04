using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace Wirex_POC.Services.Confirmation
{
    public class Confirmation
    {

        public static async Task ConfirmPhoneNumber(string accessToken)
        {

            string url = "https://api-baas.wirexapp.tech/api/v1/confirmation/sms";


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(uriString: url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization",  accessToken},
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                },
                Content = new StringContent("{\"action_type\":\"VerifyPhone\"}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task VerifySMSCode(string accessToken, string code, string session_id)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/confirmation/sms/verify";

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
                code,
                session_id
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
