using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //add(element)  adds an element to the List<T>
            //count() number of elements in the List<T>
            //remove(element) removes an element (returns true / false)
            //removeAt(index) removes an element at a certain index
            //removeAll()  numbers.RemoveAll(x => x == 1)
            //insert(index, element) 
            //Contains(element) determines whether an element is in the list  // // bool found = numbers.Contains(1);            
            //Console.WriteLine(numbers[3]) - giving the element in the index;
            //Sort() – sorts the array / list in ascending order
            // List<object> list = new List<object>()

            string values = Console.ReadLine();
            string[] splittedValues = ;
            List<int> intValues = values.Split(' ').Select(Convert).ToList();

        }
        static int Convert(string originalValue)
        {
            int newValue = int.Parse(originalValue);
            return newValue;

            
            
        }
    }
}
