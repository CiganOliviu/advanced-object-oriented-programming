using System;

namespace BankingExample
{
    public class Account
    {
        private double _balance;

        protected double Balance
        {
            get => _balance;
            set
            {
                if (value >= 0)
                    _balance = value;   
            }
        }

        protected Account(double balance)
        {
            Balance = balance;
        }

        public virtual bool SetDeposit(double amount)
        {
            return false;
        }

        public virtual bool SetWithdraw(double amount)
        {
            return true;
        }

        public virtual void PrintBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}