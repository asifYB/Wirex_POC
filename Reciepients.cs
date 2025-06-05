using System.Text.Json;
using System.Text;

namespace Wirex_POC
{
    public class Reciepients
    {
        public static async Task GetReciepients(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients";

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


        public static async Task CreateReciepients(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients";

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
                company_name = "YellowBlock",
                first_name = "Mohammad",
                is_business = true,
                last_name = "Mohammad Asif"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


        public static async Task GetReciepientByCatalouge(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients/filter/catalog?catalog_index=A";

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

        public static async Task GetReciepientByCurrency(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients/filter/currency?currency=EUR";

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


        public static async Task GetReciepientByName(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients/filter/name?name=Asi";

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


        public static async Task GetReciepientByType(string accessToken)
        {
            string url = "https://api-baas.wirexapp.tech/api/v1/recipients/filter/type?type=Sepa";

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


        public static async Task GetReciepientById(string accessToken, string recipientId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}";

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


        public static async Task DeleteReciepient(string accessToken, string recipientId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
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


        public static async Task UpdateReciepient(string accessToken, string recipientId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}";

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
                company_name = "YellowBlock",
                first_name = "Mohammad",
                is_business = true,
                last_name = "Mohammad Asif"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

        public static async Task CreatePaymentDetails(string accessToken, string recipientId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}/payment_details";

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
                type = "Sepa", 
                currencies = new[] { "EUR", "USD" },

                sepa = new
                {
                    iban = "DE89370400440532013000",
                    bic = "COBADEFFXXX",
                    account_holder = "Mohammad Asif"
                }
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

        public static async Task DeletePaymentDetails(string accessToken, string recipientId, string paymentDetailsId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}/payment_details/{paymentDetailsId}";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
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

        public static async Task UpdatePaymentDetailsAsync(string accessToken, string recipientId, string paymentDetailsId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}/payment_details/{paymentDetailsId}";

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
                type = "Sepa", // Options: "Crypto", "Sepa", "FasterPayment", "Ach", "Swift", "Card"
                currencies = new[] { "EUR", "USD" },

                sepa = new
                {
                    iban = "DE12345678901234567890",
                    bic = "NTSBDEB1XXX",
                    account_holder = "Mohammad Asif Updated"
                }
                 
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }



        public static async Task IncrementRecipientUSage(string accessToken, string recipientId)
        {
            string url = $"https://api-baas.wirexapp.tech/api/v1/recipients/{recipientId}/usage";

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
                company_name = "YellowBlock",
                first_name = "Mohammad",
                is_business = true,
                last_name = "Mohammad Asif"
            };

            string jsonPayload = JsonSerializer.Serialize(payload);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }


    }
}
