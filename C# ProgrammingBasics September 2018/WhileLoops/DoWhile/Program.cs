using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName;
            string password;
            int retries = 0;
            do
            {
                retries++;
                Console.Write("Username: ");
                userName = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
            } while (password != "test" && retries < 3);            

            if (retries == 3)
            {
                Console.WriteLine("Your accont is locked");
            }
            else
            {
                Console.WriteLine($"Hello {userName}");

            }
        }
    }
}
