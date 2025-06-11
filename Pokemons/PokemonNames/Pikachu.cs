using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Pokemons.PokemonSubclasses;
using PokemonSimulator.Pokemons.PokemonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonSimulator.Pokemons.PokemonNames
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {
        private int evolveAtLevel = 16; // Pikachu evolves at level 16
        public Pikachu(int level, List<Attack> attacks) : base("Pikachu", level, attacks) { }

        public Pokemon Evolve()
        {
            var oldName = Name;
            var newPokemon = new Raichu(Level + 10, Attacks);
            UI.Print($"{oldName} is evolving... Now it's {newPokemon.Name}! Level: {newPokemon.Level}!");
            return newPokemon;

        }
        public override void Speak()
        {
            UI.Print("Pika Pika!");
        }

        public override Pokemon RaiseLevel()
        {
            base.RaiseLevel();
            if (Level >= evolveAtLevel)
            {
                return Evolve();  // ตรงนี้พิมพ์วิวัฒนาการครั้งเดียว
            }
            return this;
        }
    }
}
