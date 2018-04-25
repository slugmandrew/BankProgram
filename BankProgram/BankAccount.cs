using System;

namespace BankProgram
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        // seed for generating account numbers
        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;

            // set the account number and increment seed
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }
}
