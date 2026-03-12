namespace Adventure
{
    internal class Program
    {
        /*
         * 1: Tee Player klass, koos viie andmeväljaga.
         * Player klassis on üks konstruktur kus kasutakse kõiki andmeid.
         * Andmeväljad on: Lives, Health, struct Location (X ja Y), Backpack, Money
         * Vaikeväärtused on Lives=3 ja Health (100)
         */

        static void Main(string[] args)
        {
            Player newPlayer = new Player(50, 5, 10, new List<BackPackItemType>() { BackPackItemType.Vibu }, new LocationType(99, 88));
            Console.WriteLine(newPlayer.ToString());
        }
    }
}
