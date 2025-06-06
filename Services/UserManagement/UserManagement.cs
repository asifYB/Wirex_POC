using System.Net.Http;
using System.Text.Json;
using System.Text;
using Wirex_POC.Services.Models;
using Wirex_POC.Services.Shared;
using System.Net.Http.Headers;

namespace Wirex_POC.Services.UserManagement
{
    public class UserManagement
    {

        public static async Task RetrieveUserInformation(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user";


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uriString: url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization",  accessToken},
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifsp21@gmail.com" }
                },
            };
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task UpdateFreshDeskId(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user/freshdesk-id";


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(uriString: url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization",  accessToken},
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifreal@gmail.com" }
                },
                Content = new StringContent("{\"freshdesk_id\":\"fresh1234\"}")
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

        public static async Task UpdatePhoneNumber(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/user/phone-number";


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(uriString: url),
                Headers =
                {
                    { "Accept", "application/json" },
                    { "Authorization",  accessToken},
                    { "X-Chain-Id", "84532" },
                    { "X-User-Email", "mohdasifsp21@gmail.com" }
                },
                Content = new StringContent("{\"is_confirmed\":true,\"phone_number\":\"+917210166106\"}")
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

        public static async Task ConfirmPhoneNumber(string accessToken, string action_token)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/user/phone-number/confirm";

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
                    { "X-User-Email", "mohdasifsp21@gmail.com" }
                }
            };

            var payload = new
            {
                action_token
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
    }
}
