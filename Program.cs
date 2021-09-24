using System;
using System.Text.Json;
using System.Collections.Generic;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var energytype = new Energytype("Lightning");
            Console.WriteLine(energytype.Type);
            var pokemon = new pokemon("Pikachu", 60, energytype);
            var attack = new Attack("Slash", 30);
            var resistance = new Resistance(energytype, 20);
            var weakness = new Weakness(energytype, 1.5F);
            Pokemons.Add(pokemon);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health},"/* {energytype.EnergyType}, {attack.Name}, {resistance.Resistance}, {weakness.Weakness}"*/);
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
