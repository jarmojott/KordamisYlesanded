
internal class Program
{
    static void Main(string[] args)
    {
        // #n1. "Tervitus"
        // kirjuta programm mis,
        // - küsib tsükliga kasutajalt tema eesnime
        // - - küsitakse uuesti tühja sisendi korral
        // - küsib kasutajalt tema keskmist nime
        // - - küsitakse uuesti tühja sisendi korral
        // - küsib kasutajalt tema perekonnanime
        // - - küsitakse uuesti tühja sisendi korral
        // - tema vanust
        // - - küsitakse uuesti tühja sisendi korral
        // - ning väljastab talle tervituslause, kasutades kõiki muutujaid
        /*
        String eesNimi = String.Empty;
        while (eesNimi == String.Empty)
        {
            Console.Write("Palun sisesta oma eesnimi: ");
            eesNimi = Console.ReadLine();
        }

        String keskmineNimi = String.Empty;
        while (!(keskmineNimi != String.Empty))
        {
            Console.Write("Palun sisesta oma keskmine nimi: ");
            keskmineNimi = Console.ReadLine();
        }

        String pereNimi = String.Empty;
        while (pereNimi == String.Empty)
        {
            Console.Write("Palun sisesta oma perenimi: ");
            pereNimi = Console.ReadLine();
        }

        int vanus = 0;
        while (vanus < 1)
        {
            Console.Write("Palun sisesta oma vanus: ");
            vanus = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Tere päevast {eesNimi} {pereNimi}!\n" +
            $"Või kutsun sind {keskmineNimi}.\n" +
            $"Oled tublisti kasvanud, oled juba {vanus}-aastane.");
        */
        // #n2. "Minu lemmiksnäkk"
        // kirjuta programm mis
        // küsib kasutajalt mis on ta lemmiksnäkk
        // programm kontrollib tsükliga kas järjendis on snäkk olemas
        // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
        // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"
        /*
        string[] snäkid = { "Lays", "Estrella", "Piraat", "Vahvel", "Kõrsik" };

        Console.Write("Palun sisesta oma lemmiksnäkk: ");
        String lemmikSnäkk = Console.ReadLine();

        bool leitud = false;
        foreach (var snäkk in snäkid)
        {
            if (snäkk.ToLower() == lemmikSnäkk.ToLower())
            {
                leitud = true;
                break;
            }
        }

        if (leitud)
            Console.WriteLine($"jaa :D tean seda, {lemmikSnäkk} on hea");
        else
            Console.WriteLine($"ei tunne kahjuks {lemmikSnäkk}-i :C");
         */
        // #n3. "Metsataimede välimääraja"
        // kirjuta programm mis
        // küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
        // kui seent, siis programm esitab seeneloendis olevad seened
        // ja küsib millise seene kohta infot infojärjendist kuvada
        // tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
        // kui marja, siis programm esitab marjaloendis olevad marja
        // ja küsib millise marja kohta infot infojärjendist kuvada
        // tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
        // siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
        // ⭐iseseisvalt lisa juurde puude tuvastamine ⭐


        /*
        List<string> valikud = new List<string>() { "seent", "marja", "puud" };

        string otsing = String.Empty;
        do
        {
            Console.Write("Tee oma valik (" + string.Join(", ", valikud) + "): ");
            otsing = Console.ReadLine();
        }
        //while (otsing != "seent" || otsing != "marja");
        while (!valikud.Contains(otsing.ToLower()));

        if (otsing.ToLower() == valikud.ElementAt(0))
        {
            List<string> seeneNimi = new List<string>() { "Kukeseen", "Puravik", "Kärbseseen" };
            List<string> seeneKirjeldus = new List<string>() { "Kukeseen on kollane.", "Puravik on pruunikas.", "Kärbseseen on pealt täpiline." };

            int valik = 0;
            do
            {
                Console.WriteLine("Palun vali numbriga seen, mille kohta soovid infot. Valikus on " + seeneNimi.Count + " seent:");
                for (int i = 1; i < seeneNimi.Count + 1; i++)
                {
                    Console.WriteLine(i + ". " + seeneNimi.ElementAt(i - 1));
                }
                valik = int.Parse(Console.ReadLine());
            }
            while (!(valik > 0 && valik <= seeneNimi.Count));
            Console.WriteLine(seeneKirjeldus.ElementAt(valik - 1));

        }
        else if (otsing.ToLower() == valikud.ElementAt(1))
        {
            string vastus = "jah";
            while (vastus == "jah")
            {
                List<string> marjaNimi = new List<string>() { "Maasikas", "Kirss", "Tikker" };
                List<string> marjaKirjeldus = new List<string>() { "Maasikas on punane.", "Kirss kasvab puu otsas.", "Tikker kasvab pöösas." };

                int valik = 0;
                do
                {
                    Console.WriteLine("Palun vali numbriga mari, mille kohta soovid infot. Valikus on " + marjaNimi.Count + " seent:");
                    for (int i = 1; i < marjaNimi.Count + 1; i++)
                    {
                        Console.WriteLine(i + ". " + marjaNimi.ElementAt(i - 1));
                    }
                    valik = int.Parse(Console.ReadLine());
                }
                while (!(valik > 0 && valik <= marjaNimi.Count));
                Console.WriteLine(marjaKirjeldus.ElementAt(valik - 1));

                Console.WriteLine("Kas tahad veel infot: jah/ei");
                vastus = Console.ReadLine().ToLower();
            }
        }
        else
        {
            string[,] puud = new string[,]
        {
            { "Kask", "Kask on valget värvi tüvega."},
            { "Kuusk", "Kuusel on okkad."},
            { "Vaher", "Vaheri leht on Kanada riigilipul."}
        };

            int valik = 0;
            do
            {
                Console.WriteLine("Palun vali numbriga puu, mille kohta soovid infot. Valikus on " + puud.GetLength(0) + " seent:");
                for (int i = 1; i < puud.GetLength(0) + 1; i++)
                {
                    Console.WriteLine(i + ". " + puud[i-1, 0]);
                }
                valik = int.Parse(Console.ReadLine());
            }
            while (!(valik > 0 && valik <= puud.GetLength(0)));
            Console.WriteLine(puud[valik-1, 1]);

        }


         */
        // #n4. "Stonksid"
        // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
        // küsib kasutajalt temapoolse investeeritava summa
        // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
        // valitud firma kohta otsustab programm kordaja.
        // kui selleks on Tesla, siis on kordaja fikseeritud -1.15 (115%)
        // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
        // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
        // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta

        // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
        // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
        // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
        // kuvatakse kasutajale tema portfelli lõppväärtus.



        //firmad.Add("Tesla", -1.15);
        //firmad.Add("TransferWise", ((double)new Random().Next(1, 100) / 1000) + 1);
        //firmad.Add("Macro$lop", -Math.Abs(((double)new Random().Next(1, 100) / 1000) + 1));


        //Õppetöö 20.02.2026 all kood olemas.

        double summa = 0;
        int valik = 0;
        int pikkus = 0;
        do
        {
            do
            {
                Console.Write("Sisesta palun investeeritav summa: ");
                summa = double.Parse(Console.ReadLine());
            } while (summa <= 0);

            List<String> firmad = new List<String> { "Tesla", "TransferWise", "Macro$lop" };
            do
            {

                for (int i = 1; i < firmad.ToArray().Length + 1; i++)
                {
                    Console.WriteLine(i + ". " + firmad.ElementAt(i - 1));
                }
                Console.Write("Tee oma valik numbriga: ");
                valik = int.Parse(Console.ReadLine());
            } while (valik <= 0 || valik > firmad.ToArray().Length);

            do
            {

                Console.Write("Kui kauaks (mitu päeva) on turul investeering: ");
                pikkus = int.Parse(Console.ReadLine());

            } while (pikkus <= 0);


            double cycleRate = 0f;
            for (int i = 1; i < pikkus + 1; i++)
            {
                double kordistaja = 0;

                double fixture = new Random().Next(1, 100);
                double result = (fixture / 1000) + 1;
                double wiseRate = result;
                double msRate = result - result * 2;
                double teslaRate = -1.15;

                Math.Abs(summa);
                switch (firmad.ElementAt(valik - 1))
                {
                    case "Tesla":
                        kordistaja = -1.15;
                        cycleRate = teslaRate;
                        //summa -= summa *kordistaja;
                        //summa *= (1 - 1.15);
                        //summa = summa * Math.Pow(kordistaja, 2);
                        summa *= -0.15;
                        break;
                    case "TransferWise":
                        cycleRate = wiseRate;
                        //summa = summa * -1.15;
                        break;
                    case "Macro$lop":
                        cycleRate = msRate;
                        //summa = summa * -1.15;

                        break;
                    default:
                        break;
                }
                Console.WriteLine(i + ". päev: " + firmad.ElementAt(valik - 1) + ", " + kordistaja + ", " + summa);
            }
            if (summa <= 0)
            {
                Console.WriteLine("PANKROT!");
                break;
            }
        }
        while (valik <= 0 || pikkus <= 0);
    }
}

