using System;
using System.Text.Json;
using System.Collections.Generic;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new pokemon("Pikachu", 60);
            Pokemons.Add(pokemon);
            var energytype = new energytype() {EnergyType = "Lightning"};
            var attack = new attack() {Name = "Slash"};
            var resistance = new resistance() {TypeName = "Lightning Resistance"};
            var weakness = new weakness() {TypeName = "Grass Weakness"};
            pokemon.Name = pokemon;
            Console.WriteLine("Hello World!");
            string host = Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.HitPoints},"/* {energytype.EnergyType}, {attack.Name}, {resistance.Resistance}, {weakness.Weakness}"*/);
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
