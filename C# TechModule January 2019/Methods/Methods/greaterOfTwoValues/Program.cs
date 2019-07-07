using System;
using System.Linq;

namespace greaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValue = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (typeOfValue == "string")
            {
                Console.WriteLine(GetMaxString(firstValue, secondValue));
            }
            else if (typeOfValue == "int")
            {
                Console.WriteLine(GetMaxInt(int.Parse(firstValue), int.Parse(secondValue)));
            }
            else if (typeOfValue == "char")
            {
                Console.WriteLine(GetMaxChar(char.Parse(firstValue), char.Parse(secondValue)));
            }
        }
        static int GetMaxInt(int firstValue, int secondValue)
        {
            int result = 0;

            if (firstValue > secondValue)
            {
                result = firstValue;
            }
            else if (secondValue >= firstValue)
            {
                result = secondValue;
            }
            return result;
        }
        static char GetMaxChar(char firstValue, char secondValue)
        {
            char result = 'a';
            if (firstValue > secondValue)
            {
                result = firstValue;
            }
            else
            {
                result = secondValue;
            }
            return result;
        }
        static string GetMaxString(string firstValue, string secondValue)
        {
            string result = string.Empty;

            //if (String.Compare(firstValue,secondValue) < 0)
            //{
            //    result = secondValue;
            //}
            //else if (String.Compare(firstValue,secondValue) > 0)
            //{
            //    result = firstValue;
            //}

            if (firstValue.Length == secondValue.Length)
            {
                for (int i = 0; i < firstValue.Length; i++)
                {
                    if (firstValue[i] < secondValue[i])
                    {
                        result = secondValue;
                        break;
                    }
                    else if (firstValue[i] > secondValue[i])
                    {
                        result = firstValue;
                        break;
                    }
                }
            }
            else
            {
                int shorterString = Math.Min(firstValue.Length, secondValue.Length);

                for (int i = 0; i < shorterString; i++)
                {
                    if (firstValue[i] < secondValue[i])
                    {
                        result = secondValue;
                        break;
                    }
                    else if (firstValue[i] > secondValue[i])
                    {
                        result = firstValue;
                        break;
                    }
                }

            }

            return result;
        }
    }
}
