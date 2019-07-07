using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            List<Person> people = new List<Person>();

            while (line[0] != "END")
            {
                string name = line[0];
                int age = int.Parse(line[1]);
                string town = line[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                line = Console.ReadLine().Split();
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMatches = 1;
            int countOfNotEqualPeople = 0;

            Person targetPerson = people[n - 1];
                
            foreach (var item in people)
            {
                if (item == targetPerson)
                {
                    continue;
                }

                if (item.CompareTo(targetPerson) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualPeople++;
                }
            }

            if (countOfMatches < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualPeople} {people.Count}");

            }
        }
    }
}
