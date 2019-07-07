using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals.Cats
{
    public class Tomcat : Cat
    {
        private const string message = "MEOW";

        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {

        }

        public override string ProduceSound()
        {
            return message;
        }
    }
}
