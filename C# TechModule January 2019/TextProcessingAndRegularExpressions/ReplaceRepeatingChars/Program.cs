using System;
using System.Text.RegularExpressions;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            var regex = new Regex(@"(.)\1+");
            
            Console.WriteLine(regex.Replace(str, "$1"));
        }
    }
}
