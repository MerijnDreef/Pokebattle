
namespace Pokebattle
{
    public class Resistance 
    {
        public Resistance(Energytype type, int resisting)
        {
            Type = type;
            Resisting = resisting;
        }
        public Energytype Type { get; private set; }
        public int Resisting { get; set; }

    }
}