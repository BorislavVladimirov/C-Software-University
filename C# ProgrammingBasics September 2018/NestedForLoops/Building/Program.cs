using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());      
            
            string type = "";
            

            for (int i = floors; i >= 1; i--)
            {
                
                for (int j = 0; j < rooms; j++)
                {
                    if (i % 2 == 0)
                    {
                        type = "O";
                    }
                    else if (i % 2 == 1)
                    {
                        type = "A";
                    }
                    if (i == floors)
                    {
                        type = "L";
                    }
                    
                    Console.Write($"{type}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
