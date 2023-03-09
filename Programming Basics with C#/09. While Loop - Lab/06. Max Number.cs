using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine(); 
            while (input != "Stop")
            {
                int n = int.Parse(input); 
                if (n > maxNumber)
                {
                    maxNumber = n;
                }
              input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
