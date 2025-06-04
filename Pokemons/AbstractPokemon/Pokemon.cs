using PokemonSimulator.Pokemons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.AbstractPokemon
{
    public abstract class Pokemon
    {
        public string Name { get; }
        public int Level { get; }
        public ElementType Type { get; protected set; }
        public List<Attack> Attracks { get; }

        // Constructor to initialize the Pokemon with its name, level, type, and attracks
        protected Pokemon(string name, int level, ElementType type, List<Attack> attracks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attracks = attracks ?? new List<Attack>();
        }

        public void RandomAttack()
        {
          
        }
        public void Attack()
        {

        }

        public void RaiseLevel()
        {

        }

    }
}
