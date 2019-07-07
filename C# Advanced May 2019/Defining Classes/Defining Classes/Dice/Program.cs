using System;

namespace Dice
{
    public class Dice
    {
        private int sides;

        private Random rnd = new Random();

        public int Roll()
        {
            int rollResult = rnd.Next(1, this.sides + 1);

            return rollResult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
