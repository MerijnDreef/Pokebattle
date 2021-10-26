namespace Pokebattle
{
    public class Weakness 
    {
        public Weakness(string typeWeak, float multiplier)
        {
            TypeWeak = typeWeak;
            Multiplier = multiplier;
        }
        public string TypeWeak { get; private set; }
        public float Multiplier { get; set; }

    }
}