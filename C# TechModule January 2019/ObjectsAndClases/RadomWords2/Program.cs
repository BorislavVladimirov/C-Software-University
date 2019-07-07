using System;
using System.Linq;

namespace RadomWords2
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomIndex = random.Next(0, words.Length);
                var tempValue = words[i];
                words[randomIndex] = tempValue;

            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
