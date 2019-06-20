using System;

namespace MoneyBook
{
    public class Calculator
    {
        // decimal principal;
        // decimal reinvestmentPercentage;
        // decimal savePercentage;
        // int yearsInvested;

        

        // public Calculator(decimal principal, decimal reinvestmentPercentage, decimal savePercentage, int yearsInvested)
        // {
        //     this.principal = principal;
        //     this.reinvestmentPercentage = reinvestmentPercentage;
        //     this.savePercentage = savePercentage;
        //     this.yearsInvested = yearsInvested;
        // }

        public static void Calculuate(decimal principal, decimal reinvestmentPercentage, decimal savePercentage, int yearsInvested)
        {
            decimal monthlyInPocket = 0M;      
            decimal monthlyReinvestmentAmount = 0M;
            decimal nextYearPrincipal = 0M;
            decimal investmentRate = 0.07M;
            decimal taxReduction = 0.65M;
            decimal amountSaved = 0M;
            decimal amountToSpendFreely = 0M;

            // calculate new principal -> for every year
            // return final monthlyInPocket as a Console.WriteLine() statement

            Console.WriteLine($"At year {yearsInvested}:");
            Console.WriteLine();
            string p = principal.ToString("C2");
            Console.WriteLine($"Principal: {p}");
            
            for (int i = 1; i <= yearsInvested; i++)
            {
                monthlyInPocket = ((principal * investmentRate) * taxReduction) / 12;
                monthlyReinvestmentAmount = monthlyInPocket * reinvestmentPercentage;
                amountToSpendFreely = monthlyInPocket - (monthlyInPocket * savePercentage) - (monthlyInPocket * reinvestmentPercentage);
                nextYearPrincipal = principal + (monthlyReinvestmentAmount * 12);
                amountSaved = amountSaved + ((monthlyInPocket * savePercentage) * 12);
                principal = nextYearPrincipal;
            }
            
            string mIP = monthlyInPocket.ToString("C2");
            Console.WriteLine($"Monthly in pocket: {mIP}");
            string aTSF = amountToSpendFreely.ToString("C2");
            Console.WriteLine($"Monthly amount I can spend freely: {aTSF}");
            string mRA = monthlyReinvestmentAmount.ToString("C2");
            Console.WriteLine($"Amount to reinvest monthly at {reinvestmentPercentage}: {mRA}");
            string aS = amountSaved.ToString("C2");
            Console.WriteLine($"Total amount saved up at {savePercentage}: {aS}");
            string nYP = nextYearPrincipal.ToString("C2");
            Console.WriteLine($"Next year's principal: {nYP}");
        }
    }
}