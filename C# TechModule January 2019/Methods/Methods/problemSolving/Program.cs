using System;
namespace problemSolving
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main(string[] args)
        {
            Random rand = new Random();
            Shuffle(rand);
            GenerateNints();

        }

        private static void GenerateNints()
        {
            hints[0] = $"the {nationalities[0]} lives in the {houses[0]} house";
            hints[1] = $"the {nationalities[1]} keeps {pets[0]} as a pet";
            hints[2] = $"the {nationalities[2]} drinks {drinks[0]}";
            hints[3] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[4] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[5] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[6] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[7] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[8] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[9] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[10] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[11] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[12] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[13] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[14] = $"the {nationalities[2]} lives in the {houses[2]} house";
        }

        private static void Shuffle(Random rand)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomHouse = i + rand.Next(0, houses.Length - i);
                Swap(i, randomHouse, houses);
            }
        }

        private static void Swap(int i, int random, string[] array)
        {
            string temp = array[i];
            array[i] = array[random];
            array[random] = temp;
        }
    }
}
