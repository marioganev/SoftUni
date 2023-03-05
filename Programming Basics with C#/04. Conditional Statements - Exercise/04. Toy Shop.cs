using System;
 
namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double holidayValue = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minons = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
 
            double puzzleValue = puzzles * 2.60;
            double dollsValue =  dolls * 3.00;
            double bearsValue =  bears * 4.10;
            double minonsValue =  minons * 8.20;
            double trucksValue = trucks *2.00;
            double orderCount = puzzles + dolls + bears + minons + trucks;
            double OrderValue = puzzleValue + dollsValue + bearsValue + minonsValue + trucksValue;
 
            if (orderCount >= 50)
            {
                OrderValue = OrderValue - OrderValue * 0.25;
            }
 
            double totalMoney = OrderValue  - OrderValue * 0.10;
 
            double moneyLeft = totalMoney - holidayValue;
            double moneyNeeded = holidayValue - totalMoney;
 
            if (totalMoney >= holidayValue)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
