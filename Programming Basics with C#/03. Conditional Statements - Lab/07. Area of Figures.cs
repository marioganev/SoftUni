using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine(Math.Round(squareArea, 3));
            }

            if (shape == "rectangle")
            {
                double rectangleA = double.Parse(Console.ReadLine());
                double rectangleB = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleA * rectangleB;
                Console.WriteLine(Math.Round(rectangleArea, 3));
            }

            if (shape == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = (circleRadius * circleRadius) * Math.PI;
                Console.WriteLine(Math.Round(circleArea, 3));


            }

            if (shape == "triangle")
            {
                double triangleB = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = (triangleB * triangleHeight) / 2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }

        }
    }
}
