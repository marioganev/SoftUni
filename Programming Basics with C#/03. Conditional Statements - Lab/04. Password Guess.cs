using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string attempt = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (attempt == pass)
            {
                Console.WriteLine("Welcome");
            }
            else Console.WriteLine("Wrong password!");
        }
    }
}
