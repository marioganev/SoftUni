using System;

namespace SchoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaners = int.Parse(Console.ReadLine());
            double penPackets = pens * 5.80;
            double markerPackets = markers * 7.20;
            double cleanerPackets = cleaners * 1.20;
            double discountPercentage = double.Parse(Console.ReadLine());

            double originalPrice = penPackets + markerPackets + cleanerPackets;
            double finalPrice = originalPrice - (originalPrice * discountPercentage / 100);

            Console.WriteLine(finalPrice);
        }
    }
}
