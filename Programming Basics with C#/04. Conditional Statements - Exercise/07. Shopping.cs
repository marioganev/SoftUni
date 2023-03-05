using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocardPrice = 250 * videocards;
            double processorPrice = (videocardPrice * 0.35) * processors;
            double ramPrice = (videocardPrice / 10) * ram;
            double finalPrice = videocardPrice + processorPrice + ramPrice;

            if (videocards > processors)
            {
                finalPrice = finalPrice - (finalPrice * 0.15);
            }

            if (budget >= finalPrice)
            {
                Console.WriteLine($"You have {budget - finalPrice:f2} leva left!");
            }
            else Console.WriteLine($"Not enough money! You need {finalPrice - budget:f2} leva more!");
        }

    }
}
