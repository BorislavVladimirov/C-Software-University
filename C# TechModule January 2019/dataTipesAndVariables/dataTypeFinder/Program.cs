using System;
using System.Numerics;

namespace dataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "END")
            {
                string dataType = "";

                if (BigInteger.TryParse(input, out BigInteger i))
                {
                    dataType = "integer";
                }
                else if (float.TryParse(input, out float f))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out char c))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input, out bool b))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
            }
        }
    }
}