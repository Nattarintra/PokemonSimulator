using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.ConsoleUI
{
    internal class SelectionHelper
    {
        public static int ReadChoice(string prompt, int min, int max)
        {
            while (true)
            {
                UI.Write(prompt);
                var input = UI.GetInput();
                if (int.TryParse(input, out int choice)
                    && choice >= min
                    && choice <= max)
                {
                    return choice;  // Return the valid choice
                }
                UI.Print("Invalid Pokémon selection. Please try again.");
            }
        }
    }
}
