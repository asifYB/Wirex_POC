using System.Net.Http.Headers;

namespace Wirex_POC.Services.Confirmation
{
    public class Confirmation
    {

        public static async Task ConfirmPhoneNumber(string accessToken)
        {

            string url = "https://api-business.wirexpaychain.tech/api/v1/confirmation/sms";


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
    }
}
