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

        public void Damage(string PokemonDamage, Energytype type, int Attack) {
            // the string is for the one that TAKES damage and with what attack, now to put it in code :I
            // I need to check for EnergyType here, but how to write that here
            
            Health -= (Attack * getAttackMultiplier(type));
        }

        /*public void learnAttack(Attack attack)
        {
            Attacks.Add(attack);
        }*/

        public int getAttackMultiplier(Energytype type)
        {
            foreach(var resistance in Resistances)
            {
                if (resistance.TypeResist == type) return resistance.Resisting;
            }
            foreach(var weakness in Weaknesses)
            {
                if (weakness.TypeWeak == type) return (int)weakness.Multiplier;
            }

            return 1;
        }
        /*public virtual void play(int happiness)
        {
            Health *= happiness;
        }*/
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
        /*public override void play(int happiness)
        {
            base.play(happiness);
        }*/
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