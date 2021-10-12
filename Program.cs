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

            Pokemons.Add(pokemon);
            Pokemons.Add(pokemonHostile);

            Console.WriteLine("press the Enter key to start the fight");
            Console.ReadLine();
            Console.WriteLine($"{pokemon.Name}, {pokemon.Health}, {pokemon.Type.Type}, {pokemon.Attacks[0].Name}, {pokemon.Attacks[1].Name}, {pokemon.Type.TypeResist}, {pokemon.Resistances[0].Resisting}, {pokemon.Type.TypeWeak}, {pokemon.Weaknesses[0].Multiplier}");
            
            pokemon.Damage(pokemonHostile, pokemon.Type, pokemon.Attacks[0]);
            pokemon.Damage(pokemon, pokemonHostile.Type, pokemonHostile.Attacks[1]);

            Console.WriteLine($"Pikachu used {pokemon.Attacks[0].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.Attacks[1].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            foreach (var pok in GetLivePokemon())
            {
                Console.WriteLine($"{pok.Name}");
            }

            pokemon.Damage(pokemonHostile, pokemon.Type, pokemon.Attacks[1]);
            pokemon.Damage(pokemon, pokemonHostile.Type, pokemonHostile.Attacks[0]);

            Console.WriteLine($"Pikachu used {pokemon.Attacks[1].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.Attacks[0].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            foreach (var pok in GetLivePokemon())
            {
                Console.WriteLine($"{pok.Name}");
            }
            Console.ReadKey();
        }

        // GetLivePokemon will check if the pokemons health isn't equal to 0, and if that is the case it will continue
        static List<pokemon> GetLivePokemon() => Pokemons.Where(x => x.Health > 0).ToList();

        // this puts the pokemon in a easy to acces list
        static List<pokemon> Pokemons = new List<pokemon>();

    }
}
