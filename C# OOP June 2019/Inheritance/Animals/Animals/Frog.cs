using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    public class Frog : Animal
    {
        private const string soundMessage = "Ribbit";

        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {

        }

        public override string ProduceSound()
        {
            return soundMessage;
        }
    }
}
