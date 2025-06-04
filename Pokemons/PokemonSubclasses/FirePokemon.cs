using PokemonSimulator.Pokemons.AbstractPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator.Pokemons.PokemonSubclasses
{
    internal class FirePokemon : Pokemon
    {

        /*
         * ถ้าให้สรุปสั้น ๆ:
         *  public FirePokemon(...)	รับค่าตอนสร้าง
         *  : base(...)	ส่งค่าไปเก็บในคลาสแม่
         *  Type = ...	ตั้งค่าธาตุให้อัตโนมัติ
         * 
         * 
         */
        public FirePokemon(string name, int level, List<Attack> attacks)
            : base(name, level, Enums.ElementType.Fire, attacks)
        {
            Type = Enums.ElementType.Fire; // Set the type of the Pokemon to Fire
        }
    }
}
