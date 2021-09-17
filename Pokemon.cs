using System.Collections.Generic;

namespace Pokebattle
{
    public class pokemon 
    {
        public string Name { get; set; }
        public energytype Type { get; set; }
        public int HitPoints { get; set; }
        public int Health { get; set; }
        public List<attack> Attacks { get; set; }
        public List<resistance> Resistances { get; set; }
        public List<weakness> Weaknesses { get; set; }

        public pokemon(){}

        public pokemon(string name, int hitpoints)
        {
            Attacks = new List<attack>(); 
            Resistances = new List<resistance>();
            Weaknesses = new List<weakness>();
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
        }

        public void Damage(string PokemonDamage, string EnergyType, int Attack, int Multiplier, int Resisting) {
            // the string is for the one that TAKES damage and with what attack, now to put it in code :I
            // I need to check for EnergyType here, but how to write that here
            
            Health -= (Attack * Multiplier - Resisting);
        }
    }
}