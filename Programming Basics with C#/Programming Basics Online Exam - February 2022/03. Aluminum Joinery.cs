using System;
 
namespace AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();
 
            double sum = 0;
 
            if (order < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                switch (size)
                {
                    case "90X130":
                        {
                            double price = 110;
                            price *= order;
 
                            if (order > 30 && order <= 60)
                            {
                                price *= 0.95;
                            }
 
                            if (order > 60)
                            {
                                price *= 0.92;
                            }
 
                            sum += price;
                            break;
                        }
                    case "100X150":
                        {
                            double price = 140;
                            price *= order;
 
                            if (order > 40 && order <= 80)
                            {
                                price *= 0.94;
                            }
 
                            if (order > 80)
                            {
                                price *= 0.90;
                            }
 
                            sum += price;
                            break;
                        }
                    case "130X180":
                        {
                            double price = 190;
                            price *= order;
 
                            if (order > 20 && order <= 50)
                            {
                                price *= 0.93;
                            }
 
                            if (order > 50)
                            {
                                price *= 0.88;
                            }
 
                            sum += price;
                            break;
                        }
                    case "200X300":
                        {
                            double price = 250;
                            price *= order;
 
                            if (order > 25 && order <= 50)
                            {
                                price *= 0.91;
                            }
 
                            if (order > 50)
                            {
                                price *= 0.86;
                            }
 
                            sum += price;
                            break;
                        }
                }
 
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
 
                if (order > 99)
                {
                    sum *= 0.96;
                }
 
                Console.WriteLine($"{sum:f2} BGN");
            }
        }
    }
}
