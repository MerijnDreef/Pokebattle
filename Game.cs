using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebattle
{
    public static class Game
    {  
        // this puts the pokemon in a easy to acces list
        public static List<Pokemon> Pokemons = new List<Pokemon>();

        public static List<Pokemon> GetLivePokemon() 
        {
            return Pokemons.Where(p => p.Health > 0).ToList();
        }
    }
}
