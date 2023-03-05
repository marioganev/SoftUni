using System;

namespace First_Steps_In_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
       
            double depositSum = double.Parse(Console.ReadLine());
            if (depositSum <= 100 && depositSum >= 10000)
            {
                Console.WriteLine("The deposit sum has to be in the [100.00 to 10000.00] interval!");
            }
            int depositTerm = int.Parse(Console.ReadLine());
            if (depositTerm >= 12 && depositTerm <= 0)
            {
                Console.WriteLine("The deposit term has to be in the [1 to 12] interval!");
            }
            double annualInterestRate = double.Parse(Console.ReadLine());
            if (annualInterestRate >= 100)
            {
                Console.WriteLine("The deposit term has to be in the [0 to 100%] interval!");
            }
        
            double sum = depositSum + depositTerm * ((depositSum * annualInterestRate) / 12);
            double accruedInterest = depositSum * (annualInterestRate / 100);
            double oneMonthInterest = accruedInterest / 12;
            double totalSum = depositSum + depositTerm * oneMonthInterest;

            Console.WriteLine(totalSum);
        }
    }
}
