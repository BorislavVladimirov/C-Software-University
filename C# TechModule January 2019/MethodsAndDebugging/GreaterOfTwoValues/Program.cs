using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string result = "";
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();


            switch (type)
            {
                case "int":
                    result = GetMax(int.Parse(firstValue), int.Parse(secondValue)).ToString();
                    break;
                case "char":
                    result = GetMax(char.Parse(firstValue), char.Parse(secondValue)).ToString();
                    break;
                case "string":
                    result = GetMax(firstValue, secondValue);
                    break;
            }

            Console.WriteLine(result);
        }  

        static int GetMax(int first , int second)
        {
            return Math.Max(first, second);
        }

        static char GetMax(char first,char second)
        {
            return (char)Math.Max(first, second);
        }

        static string GetMax(string first, string second)
        {
            string result = "";

            int diff = first.CompareTo(second);

            switch (diff)
            {
                case -1:
                    result = second;
                        break;
                case 1:
                    result = first;
                    break;
            }
            return result;
        }
    }
}
