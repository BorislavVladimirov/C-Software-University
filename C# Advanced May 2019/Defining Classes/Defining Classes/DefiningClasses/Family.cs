using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> familyMembers;
        public Family()
        {
            familyMembers = new List<Person>();
        }
        public void AddMember(Person person)
        {
            familyMembers.Add(person);
        }
        //public Person GetOldestMember()
        //{
        //    Person oldest = familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
        //    return oldest;
        //}

        public void Print()
        {
            List<Person> peopleOlderThan30 = new List<Person>();

            peopleOlderThan30.AddRange(familyMembers.Where(x => x.Age > 30).OrderBy(x => x.Name));

            foreach (var currentPerson in peopleOlderThan30)
            {
                Console.WriteLine($"{currentPerson.Name} - {currentPerson.Age}");
            }
        }
    }
}
