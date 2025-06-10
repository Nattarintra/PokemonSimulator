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
    internal abstract class FirePokemon : Pokemon
    {

        /*
         *
         *  public FirePokemon(...)	Receive values during object creation
         *  : base(...)	Receive values during object creation
         *  Type = ...	Automatically set the element type          
         * 
         */
        public FirePokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Fire, attacks)
        {
            Type = ElementType.Fire; // Set the type of the Pokemon to Fire
        }
    }
}
