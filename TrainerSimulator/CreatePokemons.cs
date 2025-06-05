using PokemonSimulator.Enums;
using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Pokemons.PokemonNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.TrainerSimulator
{
    internal class CreatePokemons
    {
        public static List<Pokemon> CreateAllPokemons()
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var watergun = new Attack("Water Gun", ElementType.Water, 10);
            var bubble = new Attack("Bubble", ElementType.Water, 5);
            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 15);
            var spark = new Attack("Spark", ElementType.Electric, 8);

            return new List<Pokemon>
            {
            new Charmander(5, new List<Attack> { flamethrower, ember }),
            new Squirtle(4, new List<Attack> { watergun, bubble }),
            new Pikachu(15, new List<Attack> { thunderbolt, spark })
            };
        }
    }
}
