using PokemonSimulator.Pokemons.Enums;

namespace PokemonSimulator.Pokemons
{
    public class Attack
    {
        string Name { get; set; }  // ชื่อของท่า
        ElementType Type { get; set; } // ธาตุของท่า
        int BasePower { get; set; } // พลังพื้นฐานของท่า

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }
        public void Use( int level)
        {
            // Logic to use the attack
            // This could include calculating damage, applying effects, etc.
            Console.WriteLine($"Using attack: {Name} with base power: {BasePower}");
        }
    }
}