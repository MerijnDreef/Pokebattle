namespace Pokebattle
{
    public class Energytype 
    {
        public Energytype(string type, string typeResist, string typeWeak) 
        {
            Type = type;
            TypeResist = typeResist;
            TypeWeak = typeWeak;
        }
        public string Type { get; set; }
        public string TypeResist { get; set; }
        public string TypeWeak { get; set; }
    }
}