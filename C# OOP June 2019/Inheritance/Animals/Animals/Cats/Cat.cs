using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Cat : Animal
    {
        public const string soundMessage = "Meow meow";

        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {

        }

        public override string ProduceSound()
        {
            return soundMessage;
        }
    }
}
