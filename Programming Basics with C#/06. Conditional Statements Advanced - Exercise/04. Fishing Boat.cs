using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
 
            double rent = 0;
            double discount = 0;
 
            switch (season)
            {
                case "Spring":
 
                    rent = 3000;
 
                    break;
 
                case "Summer":
                case "Autumn":
 
                    rent = 4200;
 
                    break;
 
                case "Winter":
 
                    rent = 2600;
 
                    break;
            }
 
            if (numberOfFishermen <= 6)
            {
                discount = 0.1;
            }
            else if (numberOfFishermen >= 7 && numberOfFishermen <= 11)
            {
                discount = 0.15;
            }
            else if (numberOfFishermen > 11)
            {
                discount = 0.25;
            }
 
            double price = rent - (rent * discount);
 
            double extraDiscount = 0;
 
            if (numberOfFishermen % 2 == 0 && season != "Autumn")
            {
                extraDiscount = 0.05;
 
                price = price - (price * extraDiscount);
            }
 
            string message = "";
 
            if (budget >= price)
            {
                double moneyLeft = budget - price;
                message = $"Yes! You have " +
                    $"{moneyLeft:f2} leva left.";
            }
            else
            {
                double moneyNeeded = price - budget;
                message = $"Not enough money! " +
                    $"You need {moneyNeeded:f2} leva.";
            }
            Console.WriteLine(message);
 
        }
    }
}
