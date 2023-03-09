using System;
 
namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Име на актьора - текст
            //	Точки от академията - реално число в интервала[2.0... 450.5]
            //		Брой оценяващи n - цяло число в интервала[1… 20]
            //		На следващите n - на брой реда:
            //		Име на оценяващия -текст
            //		Точки от оценяващия -реално число в интервала[1.0... 50.0]
            string nameActor = Console.ReadLine();
            double pointsAcademi=double.Parse(Console.ReadLine());
            int numbEvalators=int.Parse(Console.ReadLine());
 
            double sum = pointsAcademi;
            for (int i = 0; i < numbEvalators; i++)
            {
                string nameEvalators = Console.ReadLine();
                double pointsEvalators = double.Parse(Console.ReadLine());
               double sumPointsEvalators = nameEvalators.Length * pointsEvalators / 2;
                sum += sumPointsEvalators;
                if(sum>1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sum:f1}!");
                    break;
                }
            }         
            //	Ако точките са над 1250.5:
            //"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
 
            if(sum<=1250.5) Console.WriteLine($"Sorry, {nameActor} you need {1250.5-sum:f1} more!");
                //"Sorry, {име на актьора} you need {нужни точки} more!"
        }
    }
}
