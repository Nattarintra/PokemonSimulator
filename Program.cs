

using PokemonSimulator.Pokemons;
using PokemonSimulator.Pokemons.Enums;
using PokemonSimulator.Pokemons.PokemonNames;

var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
var ember = new Attack("Ember", ElementType.Fire, 6);


var charmander = new Charmander(5, new List<Attack> { flamethrower, ember });
Console.WriteLine(charmander.Name); // Output: Charmander