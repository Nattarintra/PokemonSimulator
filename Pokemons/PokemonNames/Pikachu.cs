using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.AbstractPokemon;
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

        public Pokemon Evolve()
        {
            string currentName = Name;
            var raichu = new Raichu(Level + 10, Attacks);
            UI.Print($"Evolving {currentName} to {raichu.Name} at level {raichu.Level}!");
            return raichu; // Return the evolved Pokemon
          
        }
        public override void Speak()
        {
            UI.Print("Pika Pika!");
        }
    }
}
