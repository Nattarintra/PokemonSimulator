using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.PokemonNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.TrainerSimulator
{
    internal class TrainerSimlator
    {
        public static void RunPokemons() 
        {
            
            var pokemons = CreatePokemons.CreateAllPokemons();

            // Display the list of Pokemons
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"\n{pokemon.Name} ({pokemon.Type}) - Level {pokemon.Level}");

                pokemon.RaiseLevel();     

                if (pokemon is IEvolvable evolvable)  
                {
                    evolvable.Evolve();
                }
                pokemon.Attack();
            }
        }
    }
}
