using System;

namespace VacationReadingList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int hours = numberOfPages / pages;
            int hoursADay = hours / numberOfDays;
            Console.WriteLine(hoursADay);
        }
    }
}
