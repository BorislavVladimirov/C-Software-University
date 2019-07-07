using System;
using System.Text;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    builder.Append(" ");
                    continue;
                }

                int digitLenght = GetNumberOfDigits(number);
                int mainDigit = number % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = ((mainDigit - 2) * 3) + 1 ;
                }

                int letterIndex = (offset + digitLenght - 1);

                char letter = (char)(97 + letterIndex);

                builder.Append(letter);
            }

            Console.WriteLine(builder);
        }

        static int GetNumberOfDigits(int number)
        {
            int count = 0;

            while (number != 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }
    }
}
