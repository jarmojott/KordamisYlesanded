namespace Adventure
{
    public enum BackPackItemType
    {
        Nuga, Kilp, Vibu
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
        int Health = 100;
        int Lives = 3;
        int Money = 0;
        List<BackPackItemType> Items = new List<BackPackItemType>();
        LocationType Location;

        public Player(int playerHealth, int playerLives, int playerMoney, List<BackPackItemType> playerBackpack, LocationType playerLocation)
        {
            Health = playerHealth;
            Lives = playerLives;
            Money = playerMoney;
            Items = playerBackpack;
            Location = playerLocation;
        }

        public override string ToString()
        {
            return $"Mängijal on {Lives} elu, {Health} HP ja {Money} raha.\nTema kordinaadid on ({Location.X}, {Location.Y})\nSeljakotis on: "+ string.Join(",", Items);
        }
    }
}
