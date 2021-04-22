using System;

namespace BankingExample
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Account savingsAccount = new Savings(5000, 0.8);
            savingsAccount.SetDeposit(3000);
            savingsAccount.PrintBalance();

            Account checkingAccount = new CheckingAccount(5000);
            checkingAccount.SetDeposit(1000);
            checkingAccount.PrintBalance();

            checkingAccount.SetWithdraw(3000);
            checkingAccount.PrintBalance();
        }
    }
}