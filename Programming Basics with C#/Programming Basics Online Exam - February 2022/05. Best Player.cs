using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int maxPoints = Int32.MinValue;
                string bestPlayer = string.Empty;
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        if (maxPoints >= 3)
                        {
                            Console.WriteLine($"{bestPlayer} has scored {maxPoints} goals and made a hat-trick !!!");
                        }
                        else
                        {
                            Console.WriteLine($"{bestPlayer} has scored {maxPoints} goals.");
                        }
                    }
                    else
                    {
                        int points = int.Parse(Console.ReadLine());
                        if (points > maxPoints)
                        {
                            bestPlayer = line;
                            maxPoints = points;
                        }
                    }
                }
            }
        }
    }
}
