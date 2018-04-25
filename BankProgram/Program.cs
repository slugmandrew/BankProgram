using System;

namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Drew Spencer", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            WaitForTermination();
        }

        private static void WaitForTermination()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
