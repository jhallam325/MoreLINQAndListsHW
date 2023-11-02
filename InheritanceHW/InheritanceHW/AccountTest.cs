using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public class AccountTest
    {
        static void Main(string[] args)
        {
            decimal savBalance = 1000m;
            decimal intRate = .1m;

            decimal checkBalance = 100m;
            decimal transFee = 1m;

            Console.WriteLine("Create Saving Account with normal parameters");
            SavingsAccount savAcc = new SavingsAccount(savBalance, intRate);
            
            Console.WriteLine($"Balance = {savAcc.Balance}");
            Console.WriteLine($"Interest Rate = {intRate}");

            Console.WriteLine($"Calculated interest = {savAcc.CalculateInterest()}");
            savAcc.Credit(savAcc.CalculateInterest());
            Console.WriteLine($"\nBalance with 10% interest: {savAcc.Balance}");

            savAcc.Debit(1000m);
            Console.WriteLine($"\nBalance after debit = {savAcc.Balance}");

            Console.WriteLine("*********************************************************");

            Console.WriteLine("Create Saving Account with bad parameters");
            Console.WriteLine("\n\t* Negative Balance:");
            SavingsAccount savAcc2 = new SavingsAccount(-5m, intRate);
            Console.WriteLine($"Balance = {savAcc2.Balance}");

            Console.WriteLine("\n\t* Negative Interest:");
            SavingsAccount savAcc3 = new SavingsAccount(5m, -5m);
            Console.WriteLine($"Interest Rate = {savAcc3.InterestRate}");

            Console.WriteLine("\n\t* High Interest:");
            SavingsAccount savAcc4 = new SavingsAccount(5m, 5m);
            Console.WriteLine($"Interest Rate = {savAcc4.InterestRate}");

        }
    }
}
