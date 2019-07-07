using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            List<KeyValue> list = new List<KeyValue>();

            // hash functionC:\Users\lp_fr\source\repos\AssociativeArrays\AssociativeArrays\Program.cs

            var fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20; 

            // хеш таблици - при обикновените dictionary

            //Sorted:
            // дърво структура от данни -> двойчно дърво
            //при sorted dictionaries


            //add();
            //remove();



            var array = new int[] { 101, 1, 6, 6, 10, 7 };
            var newCollection = array.Where(x => x > 5).ToDictionary(x => x, x => 0);

            foreach (var item in newCollection)
            {
                Console.WriteLine();
            }
        }
    }

    class KeyValue
    {

        public KeyValue(string index, int value)
        {
            Index = index;
            Value = value;
        }
        public string Index { get; set; }

        public int Value { get; set; }
    }
}
