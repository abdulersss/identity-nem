using System;
using System.Threading.Tasks;
using io.nem1.sdk.Model.Accounts;
using io.nem1.sdk.Infrastructure.HttpRepositories;
using io.nem1.sdk.Model.Blockchain;
using io.nem1.sdk.Model.Wallet;
using System.Reactive.Linq;
using io.nem1.sdk.Model.Transactions;
using io.nem1.sdk.Model.Mosaics;
using io.nem1.sdk.Model.Transactions.Messages;
using System.Collections.Generic;

namespace Nem1Test
{
    class Program
    {
        readonly static string host = "http://" + Config.Domain + ":7890";

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // SimpleWallet wallet = SimpleWallet.CreateNewSimpleWallet("Wall22", new Password("P@ssword1"), NetworkType.Types.TEST_NET);
            // Console.WriteLine(wallet.WalletObj.Accounts.Account[0].ToString());
            //Console.WriteLine("----------------");
            //Console.WriteLine(wallet.WriteFile());

            getResponse();
            Console.ReadKey();


        }

        public static async Task GetAccInfo()
        {
            var accountHttp = new AccountHttp(host);
            var address = Address.CreateFromEncoded("TCTUIF-557ZCQ-OQPW2M-6GH4TC-DPM2ZY-BBL54K-GNHR");
            var accountInfo = await accountHttp.GetAccountInfo(address);
            Console.WriteLine(accountInfo.Address.Pretty);
        }

        public static async Task GetNisHeartBeat()
        {
            var nisHttp = new NisHttp(host);
            var status = await nisHttp.GetNisHeartBeat();
            Console.WriteLine(status.Message);
        }

        public static async Task getResponse()
        {
            try
            {
                Account account = Account.CreateFromPrivateKey("5cd5a454be8045056bd3c5e67c20dea92a8eb4921351d850f0249983a804a903", NetworkType.Types.TEST_NET);
                KeyPair keyPair = account.KeyPair;


                var transaction = TransferTransaction.Create(
                    NetworkType.Types.TEST_NET,
                    Deadline.CreateHours(2),
                    Address.CreateFromEncoded("TB2Z7J-R2K3BZ-2TRS6D-H5747F-Y3XKUM-BNWCI4-BPDJ"),
                    new List<Mosaic> { Xem.CreateRelative(10) },
                    PlainMessage.Create("Well shit. W/ mosaic")
                );


                SignedTransaction signedTransaction = transaction.SignWith(keyPair);

                TransactionResponse response = await new TransactionHttp("http://" + Config.Domain + ":7890").Announce(signedTransaction);
                Console.WriteLine(response.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
