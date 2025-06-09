using PokemonSimulator.Attacks;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.PokemonSubclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonNames
{
    internal class Charmander : FirePokemon
    {
        // Constructor for Charmander that takes level and a list of attacks
        public Charmander(int level, List<Attack> attacks) :base("Charmander", level, attacks)//
        { }
       
    }
}
