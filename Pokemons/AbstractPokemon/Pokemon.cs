using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.AbstractPokemon
{
    public abstract class Pokemon
    {
        private string _name;
        private int _level;
        public ElementType Type { get; protected set; }
        public List<Attack> Attacks { get; private set; }
        public string Name 
        { get => _name; 
            protected set
            {
                if(value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Name must be between 2 and 15 characters long.");
                }
                _name = value;
            }

        }
        public int Level 
        { get => _level; 
            protected set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Level must be at least 1.");
                }
                _level = value;
            }
        }
       

        // Constructor to initialize the Pokemon with its name, level, type, and attracks
        protected Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            _name = name;
            _level = level;
            Type = type;
            Attacks = attacks;
        }

        public void RandomAttack()
        {
            var random = new Random();
            var attack = Attacks[random.Next(Attacks.Count)];
            attack.Use(Level); // Use the attack with the current level

        }
        public void Attack()
        {
            Attacks[0].Use(Level); // Use the first attack in the list with the current level
        }

        public void RaiseLevel()
        {
            Level++;
            UI.Print($"{Name} has leveled up to level {Level}!");

        }

    }
}
