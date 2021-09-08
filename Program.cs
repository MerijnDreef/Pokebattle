using System;
using Pokebattle.pokemons;
using Pokebattle.Attacks;
using Pokebattle.EnergyTypes;
using Pokebattle.Resistances;
using Pokebattle.Weaknesses;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new pokemon() {name = "pikachu"};
            var energytype = new energytype() {name = "Lightning"};
            Console.WriteLine("Hello World!");
            string host = Console.ReadLine();
            Console.WriteLine(pokemon.name, energytype.name);
            Console.ReadKey();
        }
    }
}
