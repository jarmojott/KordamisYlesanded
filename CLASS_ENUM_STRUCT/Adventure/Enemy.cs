namespace Adventure
{
    public class Enemy
    {
        public string Name;
        public int Health;
        public int Lives = 1;
        public string CatchPhrase;
        public int HitPower;

        public Enemy(string name, int health, string catchPhrase, int hitPower)
        {
            Name = name;
            Health = health;
            CatchPhrase = catchPhrase;
            HitPower = hitPower;
        }
    }
}
