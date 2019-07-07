using System;
using System.Text;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int bigestScore = int.MinValue;
            string winnersName = string.Empty;

            while (name != "STOP")
            {
                int currentSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    currentSum += name[i];
                }
                if (currentSum > bigestScore)
                {
                    bigestScore = currentSum;
                    winnersName = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnersName} - {bigestScore}!");
        }
    }
}
