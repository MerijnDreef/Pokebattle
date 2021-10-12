using System.Collections.Generic;
namespace Pokebattle
{
    public class pokemon 
    {
        public string Name { get; private set; }
        public Energytype Type { get; private set; }
        private int HitPoints { get; set; }
        public int Health { get; private set; }
        internal List<Attack> Attacks { get; set; }
        internal List<Resistance> Resistances { get; set; }
        internal List<Weakness> Weaknesses { get; set; }

        public pokemon(string name, int hitpoints, Energytype energytype, List<Attack> attacks = null, List<Resistance> resistances = null, List<Weakness> weaknesses = null)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
            Type = energytype;
            Attacks = attacks ?? new List<Attack>(); 
            Resistances = resistances ?? new List<Resistance>();
            Weaknesses = weaknesses ?? new List<Weakness>();
        }
        /*
         * what it does first is, it looks if the weakness energytype is the same energytype as pokemon it's fighting
         * the second one checks if the resistance energytype is the same as the other pokemons energytype
         * the last thing will just attack if the other ones didn't work
         *
         */
        public void Damage(pokemon receiver, Energytype type, Attack attack) {
            if (receiver.Type.TypeWeak == type.Type)
            {
                receiver.Health -= (int)(attack.Damage * receiver.Weaknesses[0].Multiplier);
            } else if(receiver.Type.TypeResist == type.Type)
            {
                receiver.Health -= (attack.Damage - receiver.Resistances[0].Resisting);
            } else
            {
                receiver.Health -= (attack.Damage);
            }
        }
    }

    public class Pikachu : pokemon
    {
        public Pikachu():base("Pikachu", 60, new Energytype("Lightning", "Fighting", "Fire"))
        {
            Attacks.Add(new Attack("Electric Ring", 50));
            Attacks.Add(new Attack("Pika Punch", 20));
            Resistances.Add(new Resistance(Type, 20));
            Weaknesses.Add(new Weakness(Type, 1.5F));
        }
    }

    public class Charmeleon : pokemon
    {
        public Charmeleon():base("Charmeleon", 60, new Energytype("Fire", "Lightning", "Water"))
        {
            Attacks.Add(new Attack("Head Butt", 10));
            Attacks.Add(new Attack("Flare", 30));
            Resistances.Add(new Resistance(Type, 10));
            Weaknesses.Add(new Weakness(Type, 2.0F));
        }
    }
}