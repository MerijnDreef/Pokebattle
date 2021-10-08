using System;
using System.Text.Json;
using System.Collections.Generic;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var energytype = new Energytype("Lightning", "Fighting", "Fire");*/
            var pokemon = new Pikachu();
            var pokemonHostile = new Charmeleon();
            //var attack = new Attack("Electric Ring", 50);
            //var resistance = new Resistance(pokemon.Type, 20);
            //var weakness = new Weakness(pokemon.Type, 1.5F);
            Pokemons.Add(pokemon);
            Pokemons.Add(pokemonHostile);
            Console.WriteLine("I summon the pokemon and their stats are");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health}, {pokemon.Type.Type}, {pokemon.Attacks[0]}, {pokemon.Attacks[1]}, {pokemon.Type.TypeResist}, {pokemon.Resistances[0]}, {pokemon.Type.TypeWeak}, {pokemon.Weaknesses[0]}");
            pokemon.Damage(pokemonHostile, pokemonHostile.Type, pokemon.Attacks[0]);
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
