using System;

namespace PalindromeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num, n, rev_no, r;
            Console.WriteLine($"Palindrome Number from 1 to {number}");
            for (num = 1; num <= number; num++)
            {
                rev_no = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    rev_no = rev_no * 10 + r;
                    n = n / 10;
                }
                if (num == rev_no)
                    Console.Write(num + " ");
                
            }
        }
    }
}
