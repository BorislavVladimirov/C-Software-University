using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TextProcessingAndRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            char.IsLetter('g');

            // substring(int index, int count) - маха 


            //Environment.NewLine;


            string name = "Ivo ";
            string lastName = "Pavlov";

            string result = string.Concat(name, lastName);

            StringBuilder temp = new StringBuilder();

            temp.Append(name);
            temp.Append(lastName);

            int n = temp.Length;
            int a = temp.Capacity;

            temp[2] = '-';

            //insert
            temp.Insert(3, "te");

            //replace
            temp.Replace("Iv", "kkkk");



            //Regex
            var text = "basjl asdjiasd joaisd";
            Regex.IsMatch(text, @"/");

            if (Regex.IsMatch(text,@" "))
            {

            }
            // \w - всички
            // \W  == ! -> всичко което не е
            // \s -> matches any white-space character
            // \d -> 0-9

            // * – matches the previous element zero or more times
            // + – matches the previous element one or more times
            // ? – matches the previous element zero or one time
            // {3} – matches the previous element exactly 3 times
            // ?: - маха 
            // ?<nameOfGroup> - даваме име на дадената група

            var matches = Regex.Matches(text, @"[a-z]");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine(temp);
        }
    }
}
