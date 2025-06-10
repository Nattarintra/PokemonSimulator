using PokemonSimulator.ConsoleUI;
using PokemonSimulator.Enums;

namespace PokemonSimulator.Attacks
{
    public class Attack
    {
       public string Name { get; }//Attack name  // ชื่อของท่า
       public  ElementType Type { get; } // ธาตุของท่า
       public int BasePower { get; } // พลังพื้นฐานของท่า

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }
        public virtual void Use( int level)
        {
            UI.Print($"Using attack: {Name} with base power: {BasePower + level }");
            
        }
    }
}