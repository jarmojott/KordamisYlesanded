namespace Adventure
{
    public class Boss : Enemy
    {
        public string BossWeaponName;
        public int BossWeaponHitPower;

        public Boss(string bossWeaponName, int bossWeaponHitPower, int health, string name, string catchPhrase, int hitPower) : base(name, health, catchPhrase, hitPower)
        {
            BossWeaponName = bossWeaponName;
            BossWeaponHitPower = bossWeaponHitPower;

            //Health = health;
            //Name = name;
            //CatchPhrase = catchPhrase;
            //HitPower = hitPower;
        }
    }
}
