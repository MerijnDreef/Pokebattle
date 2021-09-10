
namespace Pokebattle.pokemons 
{
    public class pokemon 
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Health { get; set; }

        public pokemon(){}

        public pokemon(string name, int hitpoints)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
        }
    }
}