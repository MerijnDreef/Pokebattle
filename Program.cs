using System;
using Pokebattle.pokemons;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new pokemon() {name = "pikachu"};
            Console.WriteLine("Hello World!");
            string host = Console.ReadLine();
            Console.WriteLine(pokemon.name);
            Console.ReadKey();
        }
    }
}
