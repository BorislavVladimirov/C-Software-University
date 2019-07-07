using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string language = string.Empty;

            switch (countryName)
            {
                case "England":
                    language = "English";                    
                    break;
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                    language = "Spanish";
                    break;
                case "Argentina":
                    language = "Spanish";
                    break;
                case "Mexico":
                    language = "Spanish";
                    break;
                default: language = "unknown";
                    break;
            }
            Console.WriteLine(language);
        }
    }
}
