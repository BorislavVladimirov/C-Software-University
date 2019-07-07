using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    for (int k  = 0; k <= n; k++)
                    {
                        for (int l = 0; l <= n; l++)
                        {
                            for (int m = 0; m <= n; m++)
                            {
                                if (i + j + k + l + m == n)
                                {
                                    count++;                                    
                                }
                            }
                        }
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
