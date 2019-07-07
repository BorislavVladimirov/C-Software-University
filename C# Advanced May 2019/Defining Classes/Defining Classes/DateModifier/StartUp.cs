using System;

namespace Date
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier date = new DateModifier(firstDate, secondDate);

            Console.WriteLine(date.GetDifference());
        }
    }
}
