using System;
using System.Text.Json;
using System.Collections.Generic;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var energytype = new Energytype("Lightning", "Fire", "Fighting");
            var pokemon = new Pikachu();
            var attack = new Attack("Slash", 30);
            var resistance = new Resistance(energytype, 20);
            var weakness = new Weakness(energytype, 1.5F);
            Pokemons.Add(pokemon);
            Console.WriteLine("I summon the pokemon and their stats are");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health}, {energytype.Type}, {attack.Name}, {attack.Damage}, {resistance.TypeResist}, {resistance.Resisting}, {weakness.TypeWeak}, {weakness.Multiplier}");
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
