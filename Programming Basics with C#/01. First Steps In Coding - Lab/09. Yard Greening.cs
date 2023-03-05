using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeter = double.Parse(Console.ReadLine());
            double sqMeterPrice = sqMeter * 7.61;
            double discount = sqMeterPrice * 0.18;
            double finalPrice = sqMeterPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
