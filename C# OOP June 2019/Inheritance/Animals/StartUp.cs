using Animals.Animals;
using Animals.Animals.Cats;
using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "Beast!")
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 3
                    && char.IsLetter(tokens[0][0])
                    && int.TryParse(tokens[1], out int x)
                    && x >= 0
                    && (tokens[2].ToLower() == "male" || tokens[2] == "female"))
                {

                    string typeOfAnimal = command;

                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string sex = tokens[2];

                    if (typeOfAnimal == "Cat")
                    {
                        Cat cat = new Cat(name, age, sex);
                        Console.WriteLine(cat.ToString());
                    }
                    else if (typeOfAnimal == "Dog")
                    {
                        Dog dog = new Dog(name, age, sex);
                        Console.WriteLine(dog.ToString());
                    }
                    else if (typeOfAnimal == "Frog")
                    {
                        Frog frog = new Frog(name, age, sex);
                        Console.WriteLine(frog.ToString());
                    }
                    else if (typeOfAnimal == "Kitten")
                    {
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten.ToString());
                    }
                    else if (typeOfAnimal == "Tomcat")
                    {
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
