using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int n = int.Parse(input);
                if (n < minNumber)
                {
                    minNumber = n;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
