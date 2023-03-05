using System;
 
namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int durationEpisode = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());
 
            double timeForLunch = durationBreak * 1.0 / 8;
            double timeForRelax = durationBreak * 1.0 / 4;
            double timeForSeries = durationBreak - timeForLunch - timeForRelax;
 
            if (timeForSeries >= durationEpisode)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeForSeries - durationEpisode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(durationEpisode - timeForSeries)} more minutes.");
            }
        }
    }
}
