using System.Text;
using System.Text.Json;
using Wirex_POC.Services.Shared;

namespace Wirex_POC.Services
{
    public class Bank
    {

        public static async Task GetBankAccounts(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/bank/accounts";

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


        public static async Task ExecuteBankTransferAsync(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/bank/transfer";

            var requestBody = new
            {
                account_id = "your_bank_account_id",
                amount = 1000.00,
                recipient = new
                {
                    name = "John Doe",
                    address = "123 Main St, Singapore"
                },
                recipient_account = new
                {
                    iban = "SG12345678901234567890",
                    swift = "BOFASG2X"
                },
                reference = "Invoice #45678",
                token_address = "0xTokenAddressUsedForTransfer"
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content,
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


        public static async Task EstimateBankTransferAsync(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/bank/transfer/estimate";

            var requestBody = new
            {
                account_id = "your_bank_account_id",
                amount = 1000.00,
                tokens = new[] { "0xTokenAddress1", "0xTokenAddress2" }
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = content,
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
