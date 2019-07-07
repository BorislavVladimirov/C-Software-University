using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                string[] tempArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tempArr[0];
                string pokemonName = tempArr[1];
                string pokemonElement = tempArr[2];
                int pokemonHealth = int.Parse(tempArr[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);

                    trainers.Add(trainerName, trainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainers[trainerName].PokemonCollection.Add(pokemon);

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.PokemonCollection.Any(x => x.Element == element))
                    {
                        trainer.Value.NumberOfBadges++;
                        continue;
                    }

                    trainer.Value.PokemonCollection.Select(x => x.Health -= 10).ToList();
                    trainer.Value.PokemonCollection.RemoveAll(x => x.Health <= 0);
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
