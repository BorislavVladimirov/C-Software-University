using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals.Cats
{
    public class Kitten : Cat
    {
        private const string message = "Meow";

        public Kitten(string name, int age)
            : base(name, age, "Female")
        {

        }

        public override string ProduceSound()
        {
            return message;
        }
    }
}
