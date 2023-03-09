using System;
 
namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //максимален брой оценки <=4, който може да получи
            int failedTimes = int.Parse(Console.ReadLine()); 
 
            double evaluationSum = 0; //сбор на вс оценки
            int evaluationCount = 0; //брой на вс оценки
            string lastExercise=""; //име на последна/текуща задача 
            int evaluation; // оценка от текуща задача 
            int failedCount = 0; //брой оценки <=4, който е получил
 
            string input = Console.ReadLine();
 
            while (input!= "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());
 
                evaluationSum += evaluation;
                evaluationCount++;
 
                if (evaluation <= 4)
                {
                    failedCount++; 
 
                    if(failedCount == failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }
 
                input = Console.ReadLine();
            }
 
            if (failedCount != failedTimes) {
                double evaluationAverage = evaluationSum / evaluationCount;
                Console.WriteLine($"Average score: {evaluationAverage:F2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
