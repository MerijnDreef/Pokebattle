using System.Collections.Generic;
namespace Pokebattle
{
    public class pokemon 
    {
        public string Name { get; private set; }
        public Energytype Type { get; private set; }
        private int HitPoints { get; set; }
        public int Health { get; private set; }
        private List<Attack> Attacks { get; set; }
        private List<Resistance> Resistances { get; set; }
        private List<Weakness> Weaknesses { get; set; }

        public pokemon(string name, int hitpoints, Energytype energytype, Attack attack)
        {
            Name = name;
            HitPoints = hitpoints;
            Health = hitpoints;
            Type = energytype;
            Attacks = new List<Attack>(); 
            Resistances = new List<Resistance>();
            Weaknesses = new List<Weakness>();
        }

        public void Damage(string PokemonDamage, Energytype type, int Attack) {
            // the string is for the one that TAKES damage and with what attack, now to put it in code :I
            // I need to check for EnergyType here, but how to write that here
            
            Health -= (Attack * getAttackMultiplier(type));
        }

        public void learnAttack(Attack attack)
        {
            Attacks.Add(attack);
        }

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
        public Pikachu():base("Pikachu", 60, new Energytype("Lightning", "Fighting", "Fire"), new Attack("Electric Ring", 50))
        {

            
           ;
            /*
             * , new Attack("Slash", 30), new Resistance(energytype, 20), new Weakness(energytype, 1.5F)
             */

        }
        /*public override void play(int happiness)
        {
            base.play(happiness);
        }*/
    }

    public class Charmeleon : pokemon
    {
        public Charmeleon():base("Charmeleon", 60, new Energytype("Fire", "Lightning", "Water"), new Attack("Flare", 30))
        {

        }
    }
}