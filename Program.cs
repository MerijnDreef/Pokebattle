using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace Pokebattle
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = new Pikachu();
            var pokemonHostile = new Charmeleon();

            Console.WriteLine("press the Enter key to start the fight");
            Console.ReadLine();
            pokemonHostile.Damage(pokemon, 0);
            pokemon.Damage(pokemonHostile, 1);

            Console.WriteLine($"{Pokemon.GetLivePokemon()}");
            Console.WriteLine($"Pikachu used {pokemon.GetAttacks()[0].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.GetAttacks()[1].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            Console.WriteLine($"{Pokemon.GetLivePokemon()}");

            pokemonHostile.Damage(pokemon, 1);
            pokemon.Damage(pokemonHostile, 0);

            Console.WriteLine($"Pikachu used {pokemon.GetAttacks()[1].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.GetAttacks()[0].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            Console.WriteLine($"{Pokemon.GetLivePokemon()}");

            Console.ReadKey();
        }
        //public static List<Pokemon> Pokemons = new List<Pokemon>();
    }
}
