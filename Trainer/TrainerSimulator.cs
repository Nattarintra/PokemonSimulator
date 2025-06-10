using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Pokemons.PokemonNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Trainer
{
    internal class TrainerSimulator
    {
        public static void TrainerRun(List<Pokemon> pokemons) 
        {
          
            // Display the list of Pokemons
            foreach (var pokemon in pokemons)
            {
                UI.Print($"\n{pokemon.Name} ({pokemon.Type}) - Level {pokemon.Level}");
               
                pokemon.RaiseLevel();
               

                if (pokemon is IEvolvable evolvable)  // Check if the Pokemon can evolve
                {
                    evolvable.Evolve();
                }
                pokemon.Attack();

                UI.Print("\n----------------------------------");
            }

        }
    }
}
