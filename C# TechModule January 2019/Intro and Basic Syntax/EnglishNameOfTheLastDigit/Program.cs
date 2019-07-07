using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;

            Console.WriteLine(NameOfLastDigit(lastDigit));
        }   
        static string NameOfLastDigit(int lastDigit)
        {
            string nameOfDigit;

            switch (lastDigit)
            {
                case 1:
                    nameOfDigit = "one";
                    break;
                case 2:
                    nameOfDigit = "two";
                    break;
                case 3:
                    nameOfDigit = "three";
                    break;
                case 4:
                    nameOfDigit = "four";
                    break;
                case 5:
                    nameOfDigit = "five";
                    break;
                case 6:
                    nameOfDigit = "six";
                    break;
                case 7:
                    nameOfDigit = "seven";
                    break;
                case 8:
                    nameOfDigit = "eight";
                    break;
                case 9:
                    nameOfDigit = "nine";
                    break;
                case 10:
                    nameOfDigit = "ten";
                    break;
                default:
                    nameOfDigit = "zero";
                    break;
            }

            return nameOfDigit;
        }
    }
}
