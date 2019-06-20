using System;
using System.IO;

namespace MoneyBook
{
    // objective: project monthly investment income at year x given initial principal and % amount 
    // reinvested after every year
    // assumptions: 7% yearly investment return

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine();           
            // Console.WriteLine("Enter starting principal:");
            decimal principal = Decimal.Parse(args[0]);
            // Console.WriteLine("Enter reinvestment percentage as a decimal:");
            decimal reinvestmentPercentage = Decimal.Parse(args[1]);
            // Console.WriteLine("Enter percentage to save as a decimal:");
            decimal savePercentage = Decimal.Parse(args[2]);
            // Console.WriteLine("Enter # of years to reinvest:");
            int yearsInvested = int.Parse(args[3]);
            // Console.WriteLine();
            
            // Calculator calculator = new Calculator(principal, reinvestmentPercentage, savePercentage, yearsInvested);
            Calculator.Calculuate(principal, reinvestmentPercentage, savePercentage, yearsInvested);
        }
    }
}
