
using System.Threading.Tasks;
using Wirex_POC.Services.Shared;
using Wirex_POC.Services.User;

namespace Wirex_POC
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
             
            GenerateToken generateToken = new GenerateToken();
            string? accessToken = await generateToken.GetAccessToken();
            Console.Write("Access Token: ", accessToken);

            User user = new User();
            await user.CreateUser(accessToken!);
            Console.Write("User Created");

 
        }
    }
}
