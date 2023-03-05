using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            double dogFoodPrice = dogFood * 2.50;
            int catFood = int.Parse(Console.ReadLine());
            double catFoodPrice = catFood * 4;
            double endSum = dogFoodPrice + catFoodPrice;

            Console.WriteLine($"{endSum} lv.");
        }
    }
}
