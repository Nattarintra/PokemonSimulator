using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Pokemons.Enums;
using System.Collections.Generic;

namespace PokemonSimulator.Pokemons.PokemonTypes
{
    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, Enums.ElementType.Electric, attacks)
        {
            Type = Enums.ElementType.Electric; 
        }
       
    }
}