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
            for (int i = 0; i < pokemons.Count; i++)
            {
                
                UI.Print($"\n{pokemons[i].Name} ({pokemons[i].Type}) - Level {pokemons[i].Level}");

                pokemons[i].Attack();

                var leveled = pokemons[i].RaiseLevel();
                pokemons[i] = leveled;

                if (pokemons[i] is IEvolvable evo)
                    pokemons[i] = evo.Evolve();
            }

        }
    }
}
