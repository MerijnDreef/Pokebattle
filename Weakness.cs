namespace Pokebattle
{
    public class Weakness 
    {
        public Weakness(Energytype type, int multiplier)
        {
            Type = type;
            Multiplier = multiplier;
        }
        public Energytype Type { get; set; }
        public float Multiplier { get; set; }

    }
}