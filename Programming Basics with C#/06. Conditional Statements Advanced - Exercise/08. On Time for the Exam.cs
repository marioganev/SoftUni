using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan examHour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan examMinute = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));
            TimeSpan comeHour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan comeMinute = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));

            var examTime = examHour + examMinute;
            var comeTime = comeHour + comeMinute;

            if (comeTime == examTime)
            {
                Console.WriteLine("On time");
            }
            else if (comeTime < examTime)
            {
                if (examTime - comeTime <= TimeSpan.FromMinutes(30))
                {
                    examTime -= comeTime;
                    Console.WriteLine("On time");
                    Console.WriteLine(examTime.Minutes + " minutes before the start");
                }
                else if (examTime - comeTime > TimeSpan.FromMinutes(30) && examTime - comeTime <= TimeSpan.FromMinutes(59))
                {
                    examTime -= comeTime;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examTime.Minutes:00} minutes before the start");
                }
                else if (examTime - comeTime > TimeSpan.FromMinutes(59))
                {
                    examTime -= comeTime;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examTime.Hours}:{examTime.Minutes:00} hours before the start");
                }
            }
            else if (comeTime > examTime)
            {
                if (comeTime - examTime <= TimeSpan.FromMinutes(59))
                {
                    comeTime -= examTime;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{comeTime.Minutes} minutes after the start");
                }
                else if (comeTime - examTime > TimeSpan.FromMinutes(59))
                {
                    comeTime -= examTime;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{comeTime.Hours}:{comeTime.Minutes:00} hours after the start");
                }
            }
        }
    }
}
