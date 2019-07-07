using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2);
            int count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if ((binary[i]) == '0')
                {
                    count++;
                }
            }
            Console.WriteLine(binary);
            Console.WriteLine(count);

        }
    }
}
