using PokemonSimulator.Pokemons.AbstractPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonSubclasses
{
    internal class Grass : Pokemon
    {
        public Grass(string name, int level, List<Attack> attacks)
           : base(name, level, Enums.ElementType.Grass, attacks)
        {
            Type = Enums.ElementType.Grass;
        }
    }
}
