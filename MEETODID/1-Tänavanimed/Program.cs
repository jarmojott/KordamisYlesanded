using System.Threading.Channels;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Sisesta tänava nimi.");
        //Console.WriteLine(inputAndCapitalize());

        List<string> nimed = new List<string>();
        Console.WriteLine("Kirjuta siia oma kodukandi tänavanimed. Lõpetamiseks kirjuta 'stop'");
        String sisestus = string.Empty;
        do
        {
            Console.WriteLine("Sisesta tänava nimi.");
            sisestus = inputAndCapitalize();

            if (sisestus.ToLower() != "stop")
                nimed.Add(sisestus);
        }
        while (sisestus.ToLower() != "stop");

        //Console.WriteLine(string.Join(nimed);

        Console.WriteLine("Sisesta ebameeldiv täht.");
        string täht = inputAndCapitalize(" ");
        List<string> filtreeritud = filtreeriAndmed(nimed, täht);
        Console.WriteLine("Filtreeritud tänava nimed:");
        kuvaAndmed(filtreeritud);
    }

    private static void kuvaAndmed(List<string> kuvatavadAndmed)
    {
        if (kuvatavadAndmed.Count > 0)
        {
            for (int i = 0; i < kuvatavadAndmed.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + kuvatavadAndmed.ElementAt(i));
            }
        } else
        {

            Console.WriteLine("Andmeid pole!");
        }
    }

    private static List<string> filtreeriAndmed(List<string> nimed, string täht)
    {
        int loendur = 0;
        List<string> filtreeritud = new List<string>();
        foreach (string nimi in nimed)
        {
            if (!nimi.ToLower().Contains(täht.Trim().ToLower()))
                filtreeritud.Add(nimi);
            else
                loendur++;
        }
        Console.WriteLine("Eemaldati "+loendur+".");
        return filtreeritud;
    }

    public static string inputAndCapitalize()
    {
        string sisestus = String.Empty;
        do
        {
            Console.Write("Sinu vastus: ");
            sisestus = Console.ReadLine();

            if (sisestus.Length == 1)
                Console.WriteLine("Tänava nimi peab olema pikem kui 1 sümbol.");
        }

        while (string.IsNullOrEmpty(sisestus) || sisestus.Length == 1);
        return sisestus.Substring(0, 1).ToUpper() + sisestus.Substring(1).ToLower();
    }

    public static string inputAndCapitalize(string addition)
    {
        string sisestus = String.Empty;
        do
        {
            Console.Write("Sinu vastus: ");
            sisestus = Console.ReadLine().Trim();

            if (sisestus.Length > 1)
                Console.WriteLine("Sisesta ainult 1 täht!");
        }

        while (string.IsNullOrEmpty(sisestus) || sisestus.Length > 1);
        return sisestus;
    }
}
