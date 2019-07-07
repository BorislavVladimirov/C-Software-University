using System;
using System.Text;
namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (var word in arr)
            {
                int count = word.Length;

                for (int j = 0; j < count; j++)
                {
                    result += word;

                }

            }

            Console.Write(result);

        }
    }
}
