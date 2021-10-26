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

            Game.Pokemons.Add(pokemon);
            Game.Pokemons.Add(pokemonHostile);

            Console.WriteLine("press the Enter key to start the fight");
            Console.ReadLine();
            //Console.WriteLine($"{pokemon.Name}, {pokemon.Health}, {pokemon.Type.Type}, {pokemon.Attacks[0].Name}, {pokemon.Attacks[1].Name}, {pokemon.Type.TypeResist}, {pokemon.Resistances[0].Resisting}, {pokemon.Type.TypeWeak}, {pokemon.Weaknesses[0].Multiplier}");
            pokemonHostile.Damage(pokemon, 0);
            pokemon.Damage(pokemonHostile, 1);

            Console.WriteLine($"Pikachu used {pokemon.GetAttacks()[0].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.GetAttacks()[1].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            foreach (var pok in Game.GetLivePokemon())
            {
                Console.WriteLine($"{pok.Name}");
            }

            pokemonHostile.Damage(pokemon, 1);
            pokemon.Damage(pokemonHostile, 0);

            Console.WriteLine($"Pikachu used {pokemon.GetAttacks()[1].Name} on {pokemonHostile.Name} and lowered it's health to {pokemonHostile.Health}");
            Console.WriteLine($"Charmeleon used {pokemonHostile.GetAttacks()[0].Name} on {pokemon.Name} and lowered it's health to {pokemon.Health}");
            Console.WriteLine("The pokemon that are alive are:");
            foreach (var pok in Game.GetLivePokemon())
            {
                Console.WriteLine($"{pok.Name}");
            }

            Console.ReadKey();
        }
       
        List<Pokemon> tmpPok = Game.GetLivePokemon();

        // this puts the pokemon in a easy to acces list
        //public static List<Pokemon> Pokemons = new List<Pokemon>();
    }
}
