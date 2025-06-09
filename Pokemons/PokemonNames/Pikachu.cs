using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.PokemonSubclasses;
using PokemonSimulator.Pokemons.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonSimulator.Pokemons.PokemonNames
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks) { }

        public void Evolve()
        {
          
            string currentName = Name;
            Name = "Raichu"; // Evolved name
            Level += 10; // Evolve at level 10
            UI.Print($"Evolving {currentName} to {Name} at level {Level}!");
           

        }
    }
}
