using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Test
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^([A-Za-z0-9!#$@?]+)=([0-9]+)<<(.+)$";
            var sb = new StringBuilder();

            var regex = new Regex(pattern);
            
            while (input != "Last note")
            {
                string name = string.Empty;
                int number = 0;
                string geohashcode = string.Empty;

                Match match = regex.Match(input);

                if (!match.Success)
                {
                    sb.AppendLine("Nothing found!");
                    input = Console.ReadLine();
                    continue;
                }

                var names = Regex.Matches(match.Groups[1].ToString(), @"[A-Za-z0-9]");

                foreach (var n in names)
                {
                    name += n.ToString();
                }

                number = int.Parse(match.Groups[2].ToString());
                geohashcode = match.Groups[3].ToString();

                if (geohashcode.Length != number)
                {
                    sb.AppendLine("Nothing found!");
                    input = Console.ReadLine();
                    continue;
                }

                sb.AppendLine($"Coordinates found! {name} -> {geohashcode}");
                
                input = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
