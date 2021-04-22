using System;

namespace BankingExample
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(double balance) : base(balance)
        {
        }

        public override bool SetDeposit(double amount)
        {
            if (amount < 0) return false;

            Balance += amount;
            return true;
        }

        private bool CanWithdraw(double amount)
        {
            return amount < 0 || amount > Balance;
        }
        
        public override bool SetWithdraw(double amount)
        {
            if (CanWithdraw(amount)) return false;

            Balance -= amount;
            return true;
        }

        public override void PrintBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}