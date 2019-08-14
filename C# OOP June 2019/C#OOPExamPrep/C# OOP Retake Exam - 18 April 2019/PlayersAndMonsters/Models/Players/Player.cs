using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private readonly ICardRepository cardRepository;
        private string username;
        private int health;

        public Player(ICardRepository cardRepository, string username, int health)
        {
            this.cardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public ICardRepository CardRepository => this.cardRepository;

        public string Username
        {
            get => this.username;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string. ");
                }

                this.username = value;
            }
        }

        public bool IsDead => this.Health <= 0;

        public int Health
        {
            get => this.health;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero. ");
                }

                this.health = value;
            }
        }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            if (this.Health - damagePoints < 0)
            {
                this.Health = 0;
                return;
            }

            this.Health -= damagePoints;
        }
    }
}
