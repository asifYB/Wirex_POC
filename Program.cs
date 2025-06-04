
using System.Threading.Tasks;
using Wirex_POC.Services.Confirmation;
using Wirex_POC.Services.KYC;
using Wirex_POC.Services.Shared;
using Wirex_POC.Services.User;
using Wirex_POC.Services.UserManagement;

namespace Wirex_POC
{
    public class Program
    {
        public static async Task Main(string[] args)
        {


            ///Token Generation
            GenerateToken generateToken = new GenerateToken();
            string? accessToken = await generateToken.GetAccessToken();
            Console.Write("Access Token: ", accessToken);


            ///User
            //User user = new User();
            //await user.CreateUser(accessToken!);
            //Console.Write("User Created");


            //KYC
            //KYC kYC = new KYC();
            //await kYC.GenerateVerificationLink(accessToken!);


            ///User Management
            //await UserManagement.RetrieveUserInformation(accessToken!);
            //await UserManagement.UpdateFreshDeskId(accessToken!);
            //await UserManagement.UpdatePhoneNumber(accessToken!);
            //await UserManagement.ConfirmPhoneNumber(accessToken!, "eyJhbGciOiJSUzI1NiIsImtpZCI6Ijc5RDVFRTdCNTM2RjJCRDQyMEI2NDRCQkNDMjhBRDhDQjY0NUU0QUIiLCJ4NXQiOiJlZFh1ZTFOdks5UWd0a1M3ekNpdGpMWkY1S3MiLCJ0eXAiOiJKV1QifQ.eyJ1c2VySWQiOiIyMGJiMDk1MS1lYTIyLTRkZjEtYTNlMi1kMjAxODc4MDFiYWMiLCJlbWFpbCI6Im1vaGRhc2lmcmVhbEBnbWFpbC5jb20iLCJjb21wYW55SWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwMDAwMDAwMTUiLCJwdXJwb3NlIjoiVmVyaWZ5UGhvbmUiLCJjb25maXJtYXRpb25UeXBlIjoiU21zIiwibmJmIjoxNzQ5MDEwNTI1LCJleHAiOjE3NDkwMTA4MjUsImlhdCI6MTc0OTAxMDUyNX0.lMFTC25jWAFspuVerpAlPzjo4rTUgNiAXA7sQvBqCcD5ZXL6uzLP-wrzooNswRRE_SJUn4dQ6kfVqcLafEU3p-C_YxszouTIYYBJ8WAnIz-ExZCyuS7mGTk6xUtZAdJPYr7345rG5CQrG1wzpLWMMFCx2qhPU5V2JnCu4M4ZHgF860iNqlSr0o7V0SAF5Mb-Gp5C3Bj2xA7qtelCJmc74vIJl9HMaeDZIli4INZkn6jhOdZs6Z6RbLSAyanWoCldSA4AjC9W0EuTH7IPajBfMgDnWRATVoygdMYJXJRlEKqYxmtcrG7q1huTFySJmLPWyZsMBT9yWkXa8XaWQKXXZQ");


            ///Confirmation
            await Confirmation.ConfirmPhoneNumber(accessToken!);

            //await Confirmation.VerifySMSCode(accessToken!, "685418", "a9d08facaf144a6f8c40e948598c9690");


        }
    }
}
