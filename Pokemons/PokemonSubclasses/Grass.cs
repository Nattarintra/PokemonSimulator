using PokemonSimulator.Attacks;
using PokemonSimulator.Enums;
using PokemonSimulator.Pokemons.AbstractPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonSubclasses
{
    internal abstract class Grass : Pokemon
    {
        public Grass(string name, int level, List<Attack> attacks)
           : base(name, level, ElementType.Grass, attacks)
        {
            Type = ElementType.Grass;
        }
    }
}
