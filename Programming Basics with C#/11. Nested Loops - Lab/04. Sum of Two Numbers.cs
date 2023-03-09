using System;
 
namespace SumOfTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); 
            int end = int.Parse(Console.ReadLine());  
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
 
            int num1 = start;
 
            while (num1 <= end)
            {
                int num2 = start;
 
                while (num2 <= end)
                {
                    counter++;
 
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                    num2++;
                }
                num1++;
                
            }
            
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
