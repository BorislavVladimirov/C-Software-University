using System;
using System.Globalization;
using System.Threading;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime today = DateTime.Now;
            //Console.WriteLine(today);

            string dateAsText = Console.ReadLine();
            
            //Thread.CurrentThread = 

            DateTime dateTime = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
