using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double points = 0;
            var redball = 0;
            var orangeball = 0;
            var yellowball = 0;
            var whiteball = 0;
            var blackball = 0;
            var otherball = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine().ToLower();
                if (color == "red")
                {
                    points += 5;
                    redball++;
                }
                if (color == "orange")
                {
                    points += 10;
                    orangeball++;
                }
                if (color == "yellow")
                {
                    points += 15;
                    yellowball++;
                }
                if (color == "white")
                {
                    points += 20;
                    whiteball++;
                }
                if (color == "black")
                {
                    points /= 2;
                    blackball++;
                }
                if (color != "red" && color != "orange" && color != "yellow" && color != "white" && color != "black")
                {
                    otherball++;
                }
            }

            Console.WriteLine("Total points: {0}", (int)points);
            Console.WriteLine("Red balls: {0}", redball);
            Console.WriteLine("Orange balls: {0}", orangeball);
            Console.WriteLine("Yellow balls: {0}", yellowball);
            Console.WriteLine("White balls: {0}", whiteball);
            Console.WriteLine("Other colors picked: {0}", otherball);
            Console.WriteLine("Divides from black balls: {0}", blackball);
        }
    }
}
