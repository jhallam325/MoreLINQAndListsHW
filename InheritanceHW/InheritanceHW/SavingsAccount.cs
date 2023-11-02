using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;
        public SavingsAccount(decimal balance, decimal interestRate ) : base(balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if ( value < 0 )
                {
                    Console.WriteLine($"Interest rate must be greater than or equal to 0.00");
                    Console.WriteLine("Interest rate set to 0.00");
                    interestRate = 0;
                }
                if ( value >= 1 )
                {
                    Console.WriteLine($"Whoa whoa whoa. This is a business! " +
                        $"We can't give an interest rate more than 100%! Are you crazy!?");
                    Console.WriteLine("Interest rate set to a reasonalable 99%");
                    interestRate = .99m;
                }
                interestRate = value;
            }
        }

        public decimal CalculateInterest()
        {
            return Balance * interestRate;
        }
    }
}
