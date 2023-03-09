using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); 
            int secondNum = int.Parse(Console.ReadLine()); 

            int oddSum;
            int evenSum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                oddSum = 0;
                evenSum = 0;

                string currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
