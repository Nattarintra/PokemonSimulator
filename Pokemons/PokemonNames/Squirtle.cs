using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Pokemons.PokemonSubclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonNames
{
    internal class Squirtle : WaterPokemon
    {
        public Squirtle(int level, List<Attack> attacks) :base("Squirtle", level, attacks) { }

        public override void Speak()
        {
           UI.Print("Squir");
        }
    }
}
