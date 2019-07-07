using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
        public static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>(); 

            for (int i = 0; i < peopleCount; i++)
            {
                var currentPerson = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])
                };

                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            string format = Console.ReadLine();

            Func<Person, string> selectFunc;

            if (format == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            else if (format == "name")
            {
                selectFunc = p => $"{p.Name}";
            }
            else if (format == "age")
            {
                selectFunc = p => $"{p.Age}";
            }
            else
            {
                selectFunc = p => $"Invalid Command!";
            }
             
            people
                .Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
