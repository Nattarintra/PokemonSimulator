using PokemonSimulator.Attacks;
using PokemonSimulator.Enums;
using PokemonSimulator.Pokemons.AbstractPokemon;
using System.Collections.Generic;

namespace PokemonSimulator.Pokemons.PokemonTypes
{
    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Electric, attacks)
        {
            Type = ElementType.Electric; 
        }
       
    }
}