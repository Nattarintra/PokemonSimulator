using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.ConsoleUI
{
    internal class UserBattleUI
    {
        public static void ShowPokemonListAndAttack(List<Pokemon> pokemons)
        {
            UI.Print("\n----------------------------------");
            UI.Print("Select Pokémon:");

            //  Display Pokémons and attacks
            for (int i = 0; i < pokemons.Count; i++)
            {
                var p = pokemons[i];
                UI.Print($"{i + 1}. {p.Name} ({p.Type}) - Level {p.Level}");
                UI.Print("Attacks:");

                for (int j = 0; j < p.Attacks.Count; j++)
                {
                    var atk = p.Attacks[j];
                    UI.Print($"{j + 1}. {atk.Name} (Base Power: {atk.BasePower}, Type: {atk.Type})");
                }

               UI.Print(""); // เว้นบรรทัด
            }

            // Select Pokémon
            UI.Write("Enter Pokémon number: ");
            if (!int.TryParse(Console.ReadLine(), out int pokemonChoice) || pokemonChoice < 1 || pokemonChoice > pokemons.Count)
            {
                UI.Print("Invalid Pokémon selection.");
                return;
            }

            var selectedPokemon = pokemons[pokemonChoice - 1];

            // Select Attack เลือกท่าโจมตี
            UI.Write("Enter attack number: ");
            if (!int.TryParse(Console.ReadLine(), out int attackChoice) || attackChoice < 1 || attackChoice > selectedPokemon.Attacks.Count)
            {
                UI.Print(" Invalid attack selection.");
                return;
            }

            var selectedAttack = selectedPokemon.Attacks[attackChoice - 1];

            // Print แสดงผลลัพธ์
            UI.Print($"\n You selected: {selectedPokemon.Name} uses the attack {selectedAttack.Name}!");
            selectedAttack.Use(selectedPokemon.Level);
        }

    }
}
