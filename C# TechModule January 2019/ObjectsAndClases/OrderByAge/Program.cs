using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];

                if (name == "End")
                {
                    break;
                }
                string ID = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person()
                {
                    Name = name,
                    ID = ID,
                    Age = age
                };

                people.Add(person);
            }
            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        class Person
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public int Age { get; set; }
        }
    }
}
