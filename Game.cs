using System.Collections.Generic;
using System.Linq;

namespace Pokebattle
{
    public static class Game
    {  
        // this puts the pokemon in a easy to acces list
        public static List<Pokemon> Pokemons = new List<Pokemon>();
        // GetLivePokemon will check if the pokemons health isn't equal to 0, and if that is the case it will continue
        public static List<Pokemon> GetLivePokemon2() 
        {
            return Pokemons.Where(p => p.Health > 0).ToList();
        }
    }
}
