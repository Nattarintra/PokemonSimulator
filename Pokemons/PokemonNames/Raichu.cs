using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Pokemons.PokemonTypes;

namespace PokemonSimulator.Pokemons.PokemonNames
{
    // Sealed Final evolution of Pikachu
    internal sealed class Raichu : ElectricPokemon
    {
        public Raichu(int level, List<Attack> attacks) : base("Raichu", level, attacks) 
        { }
        public override void Speak()
        {
            UI.Print("Raichu roar!!");
        }

    }
}