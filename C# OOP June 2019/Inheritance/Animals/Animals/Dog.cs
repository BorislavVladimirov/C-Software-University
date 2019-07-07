using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Dog : Animal
    {
        private const string soundMessage = "Woof!";

        public Dog(string name, int age, string sex)
            :base (name, age, sex)
        {

        }

        public override string ProduceSound()
        {
            return soundMessage;
        }
    }
}
