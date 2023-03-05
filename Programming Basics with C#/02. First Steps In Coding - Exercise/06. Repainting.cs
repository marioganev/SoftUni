using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityThinner = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());


            double pricePerNylon = 1.5;
            double pricePerPaint = 14.5;
            double pricePerThinner = 5;
            double bags = 0.4;


            double sumForNylon = (quantityNylon + 2 )* pricePerNylon;
            double sumForPaint = (quantityPaint + (quantityPaint * 0.1)) * pricePerPaint;
            double sumPerThinner = quantityThinner * pricePerThinner;

            double totalSumMaterials = sumForNylon + sumForPaint + sumPerThinner + bags;

            double paymenForMastres = (totalSumMaterials * 0.3) * neededHours;

            double totalCosts = totalSumMaterials + paymenForMastres;

            Console.WriteLine(totalCosts);


        }
    }
}
