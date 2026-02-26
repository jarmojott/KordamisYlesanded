using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        /* Kirjuta, koos sisendikontrolliga ja sisesndi normaliseerimisega programm:
         * küsib kasutajalt 3 tehet, esimene ja kolmas peaksid olema sulgude vahel.
         * kasutaja saab määrata igale tehtele märgi.
         * 
         */

        string[] tehteRida = new string[7];
        Console.WriteLine("### Sulgudega kalkulaator ###");
        Console.WriteLine("(arv tehe arv ) tehe (arv tehe arv)");

        for (int i = 0; i < tehteRida.Length; i++)
        {
            string sisestus = String.Empty;
            do
            {
                if (i % 2 == 0)
                {
                    do
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} element milleks on arv:");
                        sisestus = Console.ReadLine();

                    } while (!double.TryParse(sisestus, out _));
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"Palun sisesta {i + 1} element milleks on tehe:");
                        sisestus = Console.ReadLine();
                    }
                    while (sisestus != "+" && sisestus != "-" && sisestus != "*" && sisestus != "/");
                }

            }
            while (sisestus == String.Empty);

            tehteRida[i] = sisestus;
        }

        double tehe = üksTehe(
            [
                üksTehe(
                [tehteRida[0], tehteRida[1], tehteRida[2]]).ToString(),tehteRida[3],
                üksTehe(
                    [tehteRida[4], tehteRida[5], tehteRida[6]]).ToString()
            ]
            );
        Console.WriteLine("Vastus on: " + tehe);
    }

    private static double üksTehe(string[] tehteRida)
    {

        switch (tehteRida[1])
        {
            case "+":
                return liitmine(double.Parse(tehteRida[0]), double.Parse(tehteRida[2]));
            case "-":
                return lahutamine(double.Parse(tehteRida[0]), double.Parse(tehteRida[2]));
            case "*":
                return korrutamine(double.Parse(tehteRida[0]), double.Parse(tehteRida[2]));
            case "/":
                return jagamine(double.Parse(tehteRida[0]), double.Parse(tehteRida[2]));
            default:
                return 0;
        }
    }

    public static double liitmine(double arv1, double arv2)
    {

        return arv1 + arv2;
    }

    public static double lahutamine(double arv1, double arv2)
    {

        return arv1 - arv2;
    }

    public static double korrutamine(double arv1, double arv2)
    {

        return arv1 * arv2;
    }

    public static double jagamine(double arv1, double arv2)
    {

        return arv1 / arv2;
    }
}
