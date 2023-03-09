using System;
 
namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
 
            //когато i e четно => i%2==0 
            //                 => (2 -> 10, 4 -> 20, 6 -> 30...и т.н.) 
            //                 => сумата, която получава е нейната възраст*5 - 1лв (взет от брат и)
            //                 => i*5-1
 
            //когато i е НЕчетно => i%2!=0 => получава играчка на стойност toyPrice
 
            double money = 0;
 
            for (int i = 1; i <=age; i++)
            {
                if (i % 2 == 0)
                {
                    // money = money + i * 5 - 1;
                    money += i * 5 - 1;
                }
                else
                {
                    //money = money + toyPrice;
                    money += toyPrice;
                }
            }
 
            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money-washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine-money:f2}");
            }
        }
    }
}
