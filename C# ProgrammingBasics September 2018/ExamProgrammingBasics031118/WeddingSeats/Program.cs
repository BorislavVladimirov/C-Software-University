using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int firstSectorRows = int.Parse(Console.ReadLine());
            int seatsCountOddRow = int.Parse(Console.ReadLine());

            char lastSector = char.Parse(a);
            int upToChar = 97 + seatsCountOddRow;
            int seatsGeneratedCount = 0;

            for (char i = 'A' ; i <= lastSector; i++)
            {
                for (int j = 1; j <= firstSectorRows; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (int k = 97; k < (upToChar+2); k++)
                        {
                            char y = Convert.ToChar(k);
                            Console.WriteLine($"{i}{j}{y}");
                            seatsGeneratedCount++;

                        }
                    }
                    else
                    {
                        for (int k = 97; k < upToChar; k++)
                        {
                            char y = Convert.ToChar(k);
                            Console.WriteLine($"{i}{j}{y}");
                            seatsGeneratedCount++;
                        }
                    }
                    
                }
                firstSectorRows += 1;
            }
            Console.WriteLine($"{seatsGeneratedCount}");
        }
    }
}
