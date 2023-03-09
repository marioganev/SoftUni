using System;
 
namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
 
 
            for (int i = 0; i < nInput; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                leftSum += n1;
            }
 
            for (int i = 0; i < nInput; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                rightSum += n2;
            }
 
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
