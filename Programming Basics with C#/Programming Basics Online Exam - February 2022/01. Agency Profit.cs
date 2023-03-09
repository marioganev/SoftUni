using System;

namespace AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();

            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double kidPrice = adultTicketPrice * 0.3;
            double serviceTax = double.Parse(Console.ReadLine());

            double adultTicketWithTax = adultTicketPrice + serviceTax;
            double finalAdultPrice = adultTickets * adultTicketWithTax; 
            double kidTicketWithTax = kidPrice + serviceTax;
            double finalKidPrice = kidTickets * kidTicketWithTax;

            double profit = (finalAdultPrice + finalKidPrice) / 5;          

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");
        }
    }
}
