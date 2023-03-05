using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;
 
            string flowersType = Console.ReadLine();
            int flowersNum = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0; ;
            switch (flowersType)
            {
                case "Roses":totalPrice = flowersNum * roses;
                    if (flowersNum > 80)
                    {
                        totalPrice *= 0.9;
                    }
                    break;
                case "Dahlias":totalPrice = flowersNum * dahlias;
                    if (flowersNum > 90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Tulips":totalPrice = flowersNum * tulips;
                    if (flowersNum > 80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Narcissus":totalPrice = flowersNum * narcissus;
                    if (flowersNum < 120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":totalPrice = flowersNum * gladiolus;
                    if (flowersNum < 80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
                default:
                    break;
            }
            double moneyLeft = budget - totalPrice;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNum} {flowersType} and {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyLeft * -1):F2} leva more.");
            }
        }
    }
}
