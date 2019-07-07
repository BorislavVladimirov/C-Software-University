using System;
using System.Collections.Generic;

namespace ObjectsAndClases
{
    class Program
    {

        class Cat
        {
            public Cat()
            {
                // empty contrustor 
            }

            public Cat(string name, int age)
            {
                //every cat should contains the two parameters 
            }

            public string Name { get; set; }
            public int Age { get; set; }

            //this. /// - сочи към текущия обект, който ще бъде инстанцира.

            
        }

        static void Main(string[] args)
        {
            var cat = new Cat("Ivan", 6);

            var listOfCats = new List<Cat>();
            listOfCats.Add(cat);



            Date today = new Date();
            today.DayOfMonth = 25;
            today.Month = 2;
            today.Year = 2019;
            today.AddYear();

            Date yesterday = new Date();
            yesterday.DayOfMonth = 24;
            yesterday.Month = 2;
            yesterday.Year = 2019;

            Date tommorow = today;
            tommorow.AddYear();



        }
    }

    class Date
    {
        public int Year;
        public int Month;
        public int DayOfMonth;

        public void AddYear()
        {
            Year++;
        }

        //ctor -- constructor
        public Date()
        {

        }

    }
    
}
