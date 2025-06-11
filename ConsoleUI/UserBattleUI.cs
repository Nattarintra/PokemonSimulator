using PokemonSimulator.Interfaces;
using PokemonSimulator.Pokemons.AbstractPokemon;
using PokemonSimulator.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

               UI.Print(); // blank
            }

            // Select Pokémon
           
            int pokemonChoice = SelectionHelper.ReadChoice("Enter Pokemon number: ", 1, pokemons.Count); ;
            

            int index = pokemonChoice - 1;
            var selectedPokemon = pokemons[index];

            // Select Attack เลือกท่าโจมตี
            int attackChoice = SelectionHelper.ReadChoice("Enter Attack number: ", 1, selectedPokemon.Attacks.Count);
            var selectedAttack = selectedPokemon.Attacks[attackChoice - 1];

            // 1. Raise level
            var result = selectedPokemon.RaiseLevel();
            pokemons[index] = result;
            selectedPokemon = result;

            // 2. Check evolution (only here)
            if (selectedPokemon is IEvolvable evolvable)
            {
                UI.Print($"{selectedPokemon.Name} is ready to evolve...");
                var evolved = evolvable.Evolve();
                pokemons[index] = evolved;
                selectedPokemon = evolved;
            }

            // Print name and attack แสดงผลลัพธ์
            UI.Print($"\nYou selected: {selectedPokemon.Name} uses the attack {selectedAttack.Name}!");
            selectedAttack.Use(selectedPokemon.Level);
        }

        
    }
}
