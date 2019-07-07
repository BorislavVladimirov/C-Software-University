using System;

namespace Defining_Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //    ADT -> "Abstract data type"

            //int siedes -> Field!  CAMELCASE
            //string Sides -> Property! PASCALCASE

            //Fields ARE ALWAYS PRIVATE



            //EXTENSIONS :
            //public static StringExtensions
            //{
            //public int[] GetNumbers (this string text)
            //{
            //    return new[] { 1, 2, 3 };
            //}
            //} 


            Car myCar = new Car(10);

            myCar.Make = "Renault";
            myCar.Model = "Megan";

            Console.WriteLine(myCar.RealAge());

            myCar.GetOld(5);

            Console.WriteLine(myCar.RealAge());
        }
    }
}
