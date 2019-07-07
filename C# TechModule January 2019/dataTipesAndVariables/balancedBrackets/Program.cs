using System;
using System.Linq;

namespace balancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string temp = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    temp += input;
                }
                else if (input == ")")
                {
                    temp += input;
                }
                if (temp == "()")
                {
                    temp = "";
                }
                else if (temp == ")" || temp == "((")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (temp == "")
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
