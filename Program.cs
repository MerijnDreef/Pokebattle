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
            Console.WriteLine("I summon the pokemon and their stats are");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health}, {pokemon.Type.Type}, {pokemon.Name}, {pokemon.Attacks.Damage}, {pokemon.Type.TypeResist}, {pokemon.Resistances.Resisting}, {pokemon.Type.TypeWeak}, {pokemon.Weaknesses.Multiplier}");
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
