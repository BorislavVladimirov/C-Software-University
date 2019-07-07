using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            string input;

            while (true)
            {
                input = Console.ReadLine();
                count++;

                if (input == book)
                {
                    Console.WriteLine($"You checked {count - 1} books and found it.");
                    break;
                }
                else if (count == capacity && input != book)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;

                }                
            }

        }
    }
}
