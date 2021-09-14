
namespace Pokebattle.pokemons 
{
    public class pokemon 
    {
        public string Name { get; set; }
        public energytype Type { get; set; }
        public int HitPoints { get; set; }
        public int Health { get; set; }
        public List<attack> Attacks { get; set; }
        public resistance Resistance { get; set; }
        public weakness Weakness { get; set; }

        public pokemon(){}

        public pokemon(string name, int hitpoints)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
        }

        public void Damage(string PokemonDamage ,int Attack ) {
            // the string is for the one that TAKES damage and with what attack, now to put it in code :I
            Health -= (Damage * Multiplier);
        }
    }
}