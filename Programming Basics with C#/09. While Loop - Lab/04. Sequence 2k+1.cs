using System;
 
namespace Sequence2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            while (2*num+1<=n)
            {
                num = num * 2 + 1;
                Console.WriteLine(num);
            }
        }
    }
}
