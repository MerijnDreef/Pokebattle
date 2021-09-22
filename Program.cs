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
            Pokemons.Add(pokemon);
            var attack = new Attack("Slash", 30);
            var resistance = new Resistance("Lightning", 20);
            var weakness = new Weakness("Grass", 15);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health},"/* {energytype.EnergyType}, {attack.Name}, {resistance.Resistance}, {weakness.Weakness}"*/);
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
