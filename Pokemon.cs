using System.Collections.Generic;
namespace Pokebattle
{
    public class Pokemon 
    {
        public string Name { get; private set; }
        public Energytype Type { get; private set; }
        private int HitPoints { get; set; }
        public int Health { get; private set; }
        protected List<Attack> Attacks { get; set; }
        protected Resistance Resistances { get; set; }
        protected Weakness Weaknesses { get; set; }

        public Pokemon(string name, int hitpoints, Energytype energytype, List<Attack> attacks, Resistance resistances, Weakness weaknesses)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
            Type = energytype;
            Attacks = attacks; 
            Resistances = resistances;
            Weaknesses = weaknesses;
        }
        /*
         * what it does first is, it looks if the weakness energytype is the same energytype as pokemon it's fighting
         * the second one checks if the resistance energytype is the same as the other pokemons energytype
         * the last thing will just attack if the other ones didn't work
         *
         */
        public void Damage(Pokemon dealer, int attack) {
            if (Type.TypeWeak == dealer.Type.Type)
            {
                Health -= (int)(dealer.Attacks[attack].Damage * Weaknesses.Multiplier);
            } else if(Type.TypeResist == Type.Type)
            {
                Health -= (dealer.Attacks[attack].Damage - Resistances.Resisting);
            } else
            {
                Health -= (dealer.Attacks[attack].Damage);
            }
        }

        public void getAttack()
        {

        }
    }

    public class Pikachu : Pokemon
    {
        public Pikachu():base("Pikachu", 60, new Energytype("Lightning", "Fighting", "Fire"), new Resistance(Type, 20), new Weakness(Type, 1.5F))
        {
            Attacks.Add(new Attack("Electric Ring", 50));
            Attacks.Add(new Attack("Pika Punch", 20));
        }
    }

    public class Charmeleon : Pokemon
    {
        public Charmeleon():base("Charmeleon", 60, new Energytype("Fire", "Lightning", "Water"), new Resistance(Type.TypeResist, 10), new Weakness(Type.TypeWeak, 2.0F))
        {
            Attacks.Add(new Attack("Head Butt", 10));
            Attacks.Add(new Attack("Flare", 30));
        }
    }
}