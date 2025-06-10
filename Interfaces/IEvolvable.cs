using PokemonSimulator.Pokemons.AbstractPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Interfaces
{
    public interface IEvolvable
    {
        // return a new pokemon
        Pokemon Evolve();   
    }
}
