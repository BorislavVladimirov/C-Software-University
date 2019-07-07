using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {

        }

        public string Name { get; set; }

        public string Adress { get; set; }

        public int Age { get; set; }
    }
}
