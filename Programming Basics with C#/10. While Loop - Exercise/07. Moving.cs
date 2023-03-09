using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int volume = w * l * h;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine(volume + " Cubic meters left.");
                    break;
                }
                int box = int.Parse(input);
                volume -= box;
                if (volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
