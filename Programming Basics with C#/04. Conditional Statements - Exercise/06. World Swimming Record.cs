using System;
namespace worldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            double timeIvan = distance * timeForMeter;
            double retard = Math.Floor(distance / 15.0) * 12.5;
            double totalTime = timeIvan + retard;
            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            if (totalTime >= record)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - record):f2} seconds slower.");
            }
        }
    }
}
