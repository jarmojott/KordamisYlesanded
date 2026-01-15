internal class Program
{
    static void Main(string[] args)
    {
        /*
        * -------------
         * MathInput1-1
         * -------------
        */

        /*
         int vanus = 0;
         Console.Write("Sisesta oma vanus: ");
         vanus = int.Parse(Console.ReadLine());

         int aastaarv = 0;
         Console.Write("Sisesta käesolev kalendriaasta: ");
         aastaarv = int.Parse(Console.ReadLine());

         int synniaasta = aastaarv - vanus;
         //Console.WriteLine(synniaasta);
        */

        /*
         * -------------
         * MathInput1-2
         * -------------
        */

        /*
        string nimi = String.Empty;
        Console.Write("Palun sisesta oma nimi: ");
        nimi = Console.ReadLine();

        Console.WriteLine($"Tervist {nimi}!");
        */


        /*
         * -------------
         * MathInput1-3
         * -------------
        */

        float kommiKaal = 0;
        int sopradeKogus = 0;

        Console.Write("Mitu grammi kommi sul on: ");
        kommiKaal = float.Parse(Console.ReadLine());

        Console.Write("Mitu sõpra sul on: ");
        sopradeKogus = int.Parse(Console.ReadLine());
        Console.WriteLine(kommiKaal / sopradeKogus + "g");

        // MathInput1-4
        // MathInput1-5
    }
}
