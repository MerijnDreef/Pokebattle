using System;
using System.Collections.Generic;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new pokemon("Pikachu", 60);
            Pokemons.Add(pokemon);
            /*var energytype = new energytype() {EnergyType = "Lightning"};
            energytype.weakness = "Water";
            var attack = new attack() {Name = "Slash"};
            var resistance = new resistance() {Resistance = "Lightning Resistance"};
            var weakness = new weakness() {Weakness = "Grass Weakness"};*/
            Console.WriteLine("Hello World!");
            string host = Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.HitPoints},"/* {energytype.EnergyType}, {attack.Name}, {resistance.Resistance}, {weakness.Weakness}"*/);
            Console.ReadKey();
        }

        static List<pokemon> Pokemons = new List<pokemon>();
    }
}
