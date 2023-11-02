using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public class Account
    {
        private decimal balance;

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0) 
                {
                    Console.WriteLine("Balance must be greater than or equal to 0.00");
                    Console.WriteLine("Balance set to 0");
                    balance = 0;
                }
                balance = value;
            }
        }

        public virtual decimal Credit(decimal amount)
        {
            return Balance += amount;
        }

        public virtual bool Debit(decimal amount)
        {
            decimal difference = Balance - amount;
            if (difference >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine($"Debit amount of {amount:C} exceeded the balance of {Balance:C}");
                return false;
            }
        }
    }
}
