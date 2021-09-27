namespace Pokebattle
{
    public class Weakness 
    {
        public Weakness(Energytype typeWeak, float multiplier)
        {
            TypeWeak = typeWeak;
            Multiplier = multiplier;
        }
        public Energytype TypeWeak { get; set; }
        public float Multiplier { get; set; }

    }
}