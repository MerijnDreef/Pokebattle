namespace Pokebattle
{
    public class Resistance 
    {
        public Resistance(string typeResist, int resisting)
        {
            TypeResist = typeResist;
            Resisting = resisting;
        }
        public string TypeResist { get; private set; }
        public int Resisting { get; set; }

    }
}