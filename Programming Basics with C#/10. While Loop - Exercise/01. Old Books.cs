using System;
 
namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
 
            int count = 0; //брояч на неуспешните опити да открием книгата
            string input = Console.ReadLine();
 
            while (input!= "No More Books")//тук ни трябва резултат=false, за да спрем цикъла
            {
                if(input== favouriteBook) //тук ни трябва резултат = true, за да спрем цикъла
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
 
                count++;
                input = Console.ReadLine();
            }
 
            //Ако не сме намерили книгата: 
            if (input == "No More Books")
             {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
