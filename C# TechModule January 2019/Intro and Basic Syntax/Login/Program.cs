using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string reversedUsername = string.Empty;

            int incorrectPasswordCount = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedUsername += username[i];
            }
            while (true)
            {
                if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else if (password != reversedUsername)
                {
                    incorrectPasswordCount++;
                    if (incorrectPasswordCount == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");                    
                }
                password = Console.ReadLine();
            }
            
        }
    }
}
