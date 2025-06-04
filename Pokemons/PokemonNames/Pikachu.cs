using PokemonSimulator.Pokemons.PokemonSubclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonNames
{
    internal class Pikachu : FirePokemon
    {
        public Pikachu(int level, List<Attack> attacks) :base("Pickachu", level, attacks) { }
    }
}
