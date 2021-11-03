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

        protected static int LivePokemon = 0;

        public Pokemon(string name, int hitpoints, Energytype energytype, Resistance resistances, Weakness weaknesses)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
            Type = energytype;
            Attacks = new List<Attack>(); 
            Resistances = resistances;
            Weaknesses = weaknesses;
            LivePokemon++;
        }

        /*
         * what it does first is, it looks if the weakness energytype is the same energytype as the pokemon it's fighting
         * the second one checks if the resistance energytype is the same as the other pokemons energytype
         * the last one will just attack if the other ones didn't work, a failsafe basically
         * also, I added the Health check here, it removes 1 from LivePokemon if Health is below or equal to 0
         */
        public void Damage(Pokemon dealer, int attack) {
            if (Type.TypeWeak == dealer.Type.Type)
            {
                Health -= (int)(dealer.Attacks[attack].Damage * Weaknesses.Multiplier);
            } else if(Type.TypeResist == dealer.Type.Type)
            {
                Health -= (dealer.Attacks[attack].Damage - Resistances.Resisting);
            } else
            {
                Health -= (dealer.Attacks[attack].Damage);
            }
            if (Health <= 0)
            {
                LivePokemon--;
            }
        }

        public List<Attack> GetAttacks()
        {
            return Attacks;
        }

        public static int GetLivePokemon()
        {
            return LivePokemon;
        }

    }

    public class Pikachu : Pokemon
    {
        public Pikachu():base("Pikachu", 60, new Energytype("Lightning", "Fighting", "Fire"), new Resistance(new Energytype("Lightning", "Fighting", "Fire").TypeResist, 20), new Weakness(new Energytype("Lightning", "Fighting", "Fire").TypeWeak, 1.5F))
        {
            Attacks.Add(new Attack("Electric Ring", 50));
            Attacks.Add(new Attack("Pika Punch", 20));
        }
    }

    public class Charmeleon : Pokemon
    {
        public Charmeleon():base("Charmeleon", 60, new Energytype("Fire", "Lightning", "Water"), new Resistance(new Energytype("Fire", "Lightning", "Water").TypeResist, 10), new Weakness(new Energytype("Fire", "Lightning", "Water").TypeWeak, 2.0F))
        {
            Attacks.Add(new Attack("Head Butt", 10));
            Attacks.Add(new Attack("Flare", 30));
        }
    }
}