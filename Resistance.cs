
namespace Pokebattle
{
    public class Resistance 
    {
        public Resistance(Energytype typeResist, int resisting)
        {
            TypeResist = typeResist;
            Resisting = resisting;
        }
        public Energytype TypeResist { get; private set; }
        public int Resisting { get; set; }

    }
}