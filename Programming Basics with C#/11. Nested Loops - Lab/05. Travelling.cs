using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal sum = 0;
                string dest = Console.ReadLine();
                if (dest == "End")
                {
                    return;
                }
                string price = Console.ReadLine();
                if (price == "End")
                {
                    return;
                }

                decimal priceInt = decimal.Parse(price);

                while (true)
                {
                    string money = Console.ReadLine();

                    if (money == "End")
                    {
                        break;
                    }

                    decimal moneyInt = decimal.Parse(money);
                    sum += moneyInt;
                    if (priceInt <= sum)
                    {
                        Console.WriteLine($"Going to {dest}!");
                        break;
                    }
                }
            }
        }
    }
}
