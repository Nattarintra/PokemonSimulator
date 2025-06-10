using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonSimulator.Attacks
{
    internal class LegendaryAttack : Attack
    {
        public LegendaryAttack(Attack baseAttack) : base(baseAttack.Name, baseAttack.Type, baseAttack.BasePower)
        {
        }


        public override void Use(int level)
        {
            UI.Print($"Using attack: {Name} with base power: {BasePower + level * 2}");

        }
    }
}
