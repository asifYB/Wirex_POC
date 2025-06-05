
using System.Threading.Tasks;
using Wirex_POC.Services;
using Wirex_POC.Services.Confirmation;
using Wirex_POC.Services.Issuance;
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

            //await Wallet.GetWalletDeatil(accessToken!);
            //{ "wallet_address":"0x7B0cb32C4d716c007Ca308F7F518f20F3880F253",
            //        "wallet_name":"Main Wallet","wallet_status":"Confirmed",
            //        "wallet_type":"Primary","balances":
            //        [
            //        { "token_symbol":"USDT","token_address":"0x2C6c7c00ACa9B9D8446d107367485079b0471706",
            //            "balance":0,"reference_balance":0,"reference_currency":"USD"},
            //        { "token_symbol":"USDC","token_address":"0x7Af7cDbd557eD302F7538Db1e3d094C8BBcA665c",
            //            "balance":0,"reference_balance":0,"reference_currency":"USD"},
            //        { "token_symbol":"DAI","token_address":"0xCdE9d704B40D254B2019af9f0c930cA7f896CC6A",
            //            "balance":0,"reference_balance":0,"reference_currency":"USD"},
            //        { "token_symbol":"EURC","token_address":"0xF70461ffb413981852683657A310892227e3989e",
            //            "balance":0,"reference_balance":0,"reference_currency":"USD"}
            //        ]
            //}

            //await Transactions.GetCardTransactions(accessToken!);

            //await Rates.GetExChangeRates(accessToken!);


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
            //await Confirmation.ConfirmPhoneNumber(accessToken!);
            //await Confirmation.VerifySMSCode(accessToken!, "685418", "a9d08facaf144a6f8c40e948598c9690");


            ///Issuance
            //await Issuance.IssuePlasticCard(accessToken!);
            //await Issuance.IssueVirtualCard(accessToken!);
            //await Issuance.ActivateCard(accessToken!, "0x7B0cb32C4d716c007Ca308F7F518f20F3880F253");



            ///Receipents
            //await Reciepients.CreateReciepients(accessToken!);
            //await Reciepients.GetReciepients(accessToken!);
            //await Reciepients.GetReciepientByCatalouge(accessToken!);
            //await Reciepients.GetReciepientByCurrency(accessToken!);
            //await Reciepients.GetReciepientByName(accessToken!);
            await Reciepients.GetReciepientByType(accessToken!);

        }
    }
}
