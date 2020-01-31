using EthereumSmartContracts.Contracts.SimpleStorage;
using EthereumSmartContracts.Contracts.SimpleStorage.ContractDefinition;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using System;
using System.Threading.Tasks;

namespace SimpleStorageConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo().Wait();
        }

        static async Task Demo()
        {
            try
            {
                // Setup
                string url = "http://testchain.nethereum.com:8545";
                var privateKey = "0x7580e7fb49df1c861f0050fae31c2224c6aba908e116b8da44ee8cd927b990b0";
                var account = new Account(privateKey);
                var web3 = new Web3(account, url);
                // An already-deployed SimpleStorage.sol contract on Rinkeby:
                var contractAddress = "0x81d0782847297956410ec1a674e60a78fff14b69";
                var service = new SimpleStorageService(web3, contractAddress);
                var increaseValue = await service.SetRequestAndWaitForReceiptAsync(300000000);
                // Get the stored value
                var currentStoredValue = await service.GetQueryAsync();
                Console.WriteLine($"Contract has value stored: {currentStoredValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}