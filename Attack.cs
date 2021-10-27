namespace Pokebattle
{
    public class Attack 
    {
        public Attack(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public string Name { get; set; }
        public int Damage { get; set; }

    }
}