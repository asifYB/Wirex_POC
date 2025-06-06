
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


            await ActivityFeed.GetActivityFeed(accessToken!);

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
            User user = new User();
            //await user.CreateUser(accessToken!);
            //Console.Write("User Created");


            //KYC
            KYC kYC = new KYC();
            //await kYC.GenerateVerificationLink(accessToken!);
            //await kYC.GenerateVerificationToken(accessToken!);
            //await kYC.GenerateSharingToken(accessToken!, "");

            ///User Management
            //await UserManagement.RetrieveUserInformation(accessToken!);
            //await UserManagement.UpdateFreshDeskId(accessToken!);
            //await UserManagement.UpdatePhoneNumber(accessToken!);
            //await UserManagement.ConfirmPhoneNumber(accessToken!, "eyJhbGciOiJSUzI1NiIsImtpZCI6Ijc5RDVFRTdCNTM2RjJCRDQyMEI2NDRCQkNDMjhBRDhDQjY0NUU0QUIiLCJ4NXQiOiJlZFh1ZTFOdks5UWd0a1M3ekNpdGpMWkY1S3MiLCJ0eXAiOiJKV1QifQ.eyJ1c2VySWQiOiJlYTFjZWQzMy00ZDU2LTQwOTYtOGI2OC1iM2Q2MTI0N2M1MGQiLCJlbWFpbCI6Im1vaGRhc2lmc3AyMUBnbWFpbC5jb20iLCJjb21wYW55SWQiOiIwMDAwMDAwMC0wMDAwLTAwMDAtMDAwMC0wMDAwMDAwMDAwMTUiLCJwdXJwb3NlIjoiVmVyaWZ5UGhvbmUiLCJjb25maXJtYXRpb25UeXBlIjoiU21zIiwibmJmIjoxNzQ5MTg0ODk0LCJleHAiOjE3NDkxODUxOTQsImlhdCI6MTc0OTE4NDg5NH0.RQCb7rsig4_Gx9BGnlgIZDh9UPQHUNsk0c0g37coxW5iU_MJ9jl9pSz_nt1dX5njR5PlrZ3xpsXvBAU9j-oDjoRbtbMdB13aJgDkWZAiHQxD0MgTeD2xHQJLgwzENfq-FLz-vsPj0KWj6-F9mecTI2ptG3I2DKUJvVu-ZXb7AQWrmJprLPMmtWrb4v2F4l3LSrZXuwqlUUD9QOot7muD_U4Ell0DMoTOBFZxscXxtwW_uhN0rPjeQZRG7JnX8UA-pRy6RA2kCAvGLd6DGLqihcckqEbo6WIqXtFAjlhQc2Tuf33D8p7HPHVJ7k16iTZEw4l0XA9gH1QOPFdevBW8Nw");


            ///Confirmation
            //await Confirmation.ConfirmPhoneNumber(accessToken!);
            //await Confirmation.VerifySMSCode(accessToken!, "488527", "509791e2e45b48939586682b2f5b2481");


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
            //await Reciepients.GetReciepientByType(accessToken!);

        }
    }
}
