using System;
using System.Text;

namespace repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string repeatedString = RepeatString(str, count);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatString(string str, int count)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= count; i++)
            {
                sb.Append(str);
                
            }
            return sb.ToString();
        }
    }
}
