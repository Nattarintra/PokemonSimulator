using PokemonSimulator.Attacks;
using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    internal class RunMain
    {
        public static void RunPokemons()
        {
            // Initialize the Pokemon simulator
            var pokemons = CreatePokemons.CreateAllPokemons();

            UI.Print("Welcome to the Pokemon Simulator!");
            UI.Print("1. Manual Play");
            UI.Print("2. Trainer Auto Simulator");
            UI.Write("Choose an option (1 or 2): ");
            string choice = UI.GetInput();

            if (choice == "1")
            {
                // Manual play mode
                UserBattleUI.ShowPokemonListAndAttack(pokemons);
            }
            else if (choice == "2")
            {
                // Trainer auto simulator mode
                TrainerSimulator.TrainerRun(pokemons);
            }
            else
            {
                UI.Print("Invalid choice. Exiting the program.");
                return;
            }
        }
    }
}
