
namespace Adventure
{
    public enum BackPackItemType
    {
        Nuga, Kilp, Vibu, katkineSaabas, mingiLambipirn, DDR5_32GB_2x16_kit, playAgain, KotitäisLambasoolikaid, Juustukera
    }

    public struct LocationType
    {
        public int X;
        public int Y;

        public LocationType(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Player
    {
        public int Health = 100;
        public int Lives = 3;
        public int Money = 0;
        public List<BackPackItemType> Backpack = new List<BackPackItemType>();
        public LocationType Location;

        public Player(int playerHealth, int playerLives, int playerMoney, List<BackPackItemType> playerBackpack, LocationType playerLocation)
        {
            Health = playerHealth;
            Lives = playerLives;
            Money = playerMoney;
            Backpack = playerBackpack;
            Location = playerLocation;
        }

        public override string ToString()
        {
            return $"Mängijal on {Lives} elu, {Health} HP ja {Money} raha.\nTema kordinaadid on ({Location.X}, {Location.Y})\nSeljakotis on: " + string.Join(",", Backpack);
        }

        public void DisplayStats()
        {
            Console.WriteLine(ToString());
        }

        public void checkHealth()
        {
            if (Health <= 0)
            {
                Lives -= 1;
                Health = 100;
            }
        }
    }
}
