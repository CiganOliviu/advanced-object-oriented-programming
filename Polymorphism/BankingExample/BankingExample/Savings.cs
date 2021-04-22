using System;

namespace BankingExample
{
    public class Savings : Account
    {
        private readonly double _interestRate;
        
        public Savings(double balance, double interestRate) : base(balance)
        {
            _interestRate = interestRate;
        }

        public override bool SetDeposit(double amount)
        {
            if (amount < 0) return false;
            
            Balance += amount + (amount * _interestRate);
            return true;
        }

        private bool CanWithdraw(double amount)
        {
            return amount < 0 || amount > Balance;
        }
        
        public override bool SetWithdraw(double amount)
        {
            if (CanWithdraw(amount)) return false;
            
            Balance -= amount + (amount * _interestRate);
            return true;
        }

        public override void PrintBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}