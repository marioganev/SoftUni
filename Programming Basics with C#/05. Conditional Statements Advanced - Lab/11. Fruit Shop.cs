using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            String fruit = Console.ReadLine().ToLower();
            String day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "thursday"
                      || day == "friday" || day == "wednesday")
            {
                if (fruit == "apple") Console.WriteLine("{0:f2}", quantity * 1.20);
                else if (fruit == "banana") Console.WriteLine("{0:f2}", quantity * 2.50);
                else if (fruit == "orange") Console.WriteLine("{0:f2}", quantity * 0.85);
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", quantity * 1.45);
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", quantity * 2.70);
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", quantity * 5.50);
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", quantity * 3.85);
                else
                    Console.WriteLine(" error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "apple") Console.WriteLine("{0:f2}", quantity * 1.25);
                else if (fruit == "banana") Console.WriteLine("{0:f2}", quantity * 2.70);
                else if (fruit == "orange") Console.WriteLine("{0:f2}", quantity * 0.90);
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", quantity * 1.60);
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", quantity * 3.00);
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", quantity * 5.60);
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", quantity * 4.20);
                else
                    Console.WriteLine(" error");
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
