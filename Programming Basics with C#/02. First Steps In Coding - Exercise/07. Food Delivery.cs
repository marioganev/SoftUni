using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            double chickenMenuPrice = chickenMenu * 10.35;
            int fishMenu = int.Parse(Console.ReadLine());
            double fishMenuPrice = fishMenu * 12.40;
            int veganMenu = int.Parse(Console.ReadLine());
            double veganMenuPrice = veganMenu * 8.15;
            double foodBill = chickenMenuPrice + fishMenuPrice + veganMenuPrice;

            double dessertPrice = foodBill / 5;
            double delivery = 2.50;

            double totalBill = foodBill + dessertPrice + delivery;
            Console.WriteLine(totalBill);
           
        }
    }
}
