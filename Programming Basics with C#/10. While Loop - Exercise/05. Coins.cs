using System;
 
namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = 100*double.Parse(Console.ReadLine()); //5,23 => 523
            int count = 0;
 
            while (changeToReturn>0)
            {
                if (changeToReturn >= 200)
                {
                    //changeToReturn = changeToReturn - 2;
                    changeToReturn -= 200;
                    count++;
                }
                else if (changeToReturn >= 100)
                {
                    //changeToReturn = changeToReturn - 1;
                    changeToReturn -= 100;
                    count++;
                }
                else if (changeToReturn >= 50)
                {
                    //changeToReturn = changeToReturn - 50;
                    changeToReturn -= 50;
                    count++;
                }
                else if (changeToReturn >= 20)
                {
                    //changeToReturn = changeToReturn - 20;
                    changeToReturn -= 20;
                    count++;
                }
                else if (changeToReturn >= 10)
                {
                    //changeToReturn = changeToReturn - 10;
                    changeToReturn -= 10;
                    count++;
                }
                else if (changeToReturn >= 5)
                {
                    //changeToReturn = changeToReturn - 5;
                    changeToReturn -= 5;
                    count++;
                }
                else if (changeToReturn >= 2)
                {
                    //changeToReturn = changeToReturn -2;
                    changeToReturn -= 2;
                    count++;
                }
                else if (changeToReturn >= 1)
                {
                    //changeToReturn = changeToReturn - 1;
                    changeToReturn -= 1;
                    count++;
                }
                else
                {
                    changeToReturn = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
