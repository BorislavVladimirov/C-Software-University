using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemonCollection;

        public Trainer()
        {
            this.pokemonCollection = new List<Pokemon>();
            this.numberOfBadges = 0;
        }

        public Trainer(string trainerName)
            : this()
        {
            this.Name = trainerName;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }

            set
            {
                this.numberOfBadges = value;
            }
        }
        public List<Pokemon> PokemonCollection
        {
            get
            {
                return this.pokemonCollection;
            }

            set
            {
                this.pokemonCollection = value;
            }
        }
    }
}
