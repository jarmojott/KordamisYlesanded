internal class Program
{
    static void Main(string[] args)
    {
        //meetoditega programm - Jõgeva - "Ilmaprognoos 2"
        //
        // * SISENDITE KÄSITLUS * 
        //
        //¤ Käsitle tekstisisendeid nii, et inimese nimi oleks kõik sõnad esisuurtäht, 
        //¤ kõik muud tekstisisendid standardiseeri kas suureks või väikeseks
        //¤ arvsisendid try-catchitakse ning catchi puhul seatakse tsükli tingimus nii, et tsükkel jätkuks ja küsimus küsitakse uuesti
        //
        // * PROGRAMMI TÖÖ *
        //
        //¤ programmis on tuplede või arrayde list kus hoitakse kolme andmet, string kasutajanimi, string pärisnimi, string parool ✅
        //¤ programmi töö alguses ei oma list mitte ühtegi andmesisestust. kasutajale antakse valik kas sisse logida või registreerida ✅
        //¤ kui registreerib, siis tehakse uus sisestus ka listi koos kolme andmega mis kasutajalt küsitakse. täisnimi (ees ja perekonnanimi), soovitud kasutajanimi ja parool ✅
        //see on kui "andmebaas" ✅
        //¤ NB! ees ja perekonnanimi küsitakse ühe sisestusega, programm ise peab ümbervormindama ta tavakujule (sisendite käsitlus) ✅
        //¤ NB! parooli *EI TOHI* mingil kujul ringi töödelda. ✅
        //¤ sisendi kättesaamiseks on oma meetod ✅
        //¤ sisendi töötlemiseks on erinevad meetodid (arvsisestuse kontroll, esisuurtähe töötlus, ja parooli (ning soovi korral ka kasutajanime) puhul ei kasutata üldse) ✅
        //¤ kui kasutaja on registreerinud siis kuvatakse endiselt sisselogimis või registreerimisvõimalus ✅
        //¤ kui kasutaja logib sisse, esitatakse talle tervitus, tema ees ja //perekonnanimega//, ✅
        //¤ kusjuures perekonnanimi "andmebaasis" olevast nimest tervituse hetkeks eemaldatakse ✅
        //¤ Programm siis küsib mitme päeva infot ta sisestada tahab. ✅ 
        //¤ Kui tehakse tühi sisestus, siis teavitatakse et on vaja vähemalt 1 päev sisestada ja küsitakse uuesti ✅

        //¤ tsüklis küsitakse niimitu korda erinevate päevade kohta infot (decimal) kui kasutaja ütles. ✅
        //¤ programm omab ka loendit nädalapäevadest ✅
        //¤ programm küsib milline nädalapäev vastab esimesena sisestatud andmele, kasutaja vastab ühe tähega ETKNRLP ✅

        //¤ Kasutades eelnevalt tunnis tehtud näiteülesannet kus kuvame välja temperatuuri pulgana, ✅
        //¤ tee meetod, mis võtab sisse temperatuuri ning nädalapäeva nime ja tekitab vastava andmepulga, kuhu *SAMA REA LÕPPU* kirjutatakse temperatuur arvväärtusena ja nädalapäeva nimi   ✅
        //¤ Tsükkel kasutab esimest nädalapäeva ja kuvab meetodi abil kõikide sisestatud päevade info.  ✅
        //¤ peale kuvamist küsib kasutajalt kas ta soovib jätkata, ning kui soovib, siis algab programm uuesti andmete sisestusest, mitte sisselogimisest, 
        //¤ kui ei, kuvatakse uuesti sisselogimine
        //
        // 40% = 3
        // 65% = 4
        // 80% = 5



        



        string[][] nädalapäevaNimed = new string[][] { ["E", "Esmaspäev"], ["T", "Teisipäev"], ["K", "Kolmapäev"], ["N", "Neljapäev"], ["R", "Reede"], ["L", "Laupäev"], ["P", "Pühapäev"] };

        List<double> temperatuurid = new List<double>();
        int päevadeKogus = sisestaTäisArv("Mitme päeva temperatuure sa sisestada tahad: ");
        int nädalapäevaAlgus = sisestaNädalapäevaTunnus("Mis nädalapäevast temperatuure sisestada soovid: ");

        int nädalapäevaNr = nädalapäevaAlgus;
        for (int i = 0; i < päevadeKogus; i++)
        {
            temperatuurid.Add(sisestaTemp("Sisesta " + nädalapäevaNimed[nädalapäevaNr][1] + " temperatuur: "));
            if (nädalapäevaNr == 6)
                nädalapäevaNr = 0;
            else
                nädalapäevaNr++;

        }

        int keskPunkt = 25; // -50 kuni +50
        Console.WriteLine("Sinu sisestatud temperatuurid:");
        nädalapäevaNr = nädalapäevaAlgus;
        foreach (var temperatuur in temperatuurid)
        {
            string displayableData = String.Empty;

            int i = 0;
            while (i < keskPunkt * 2)
            {
                double sm0 = (keskPunkt + temperatuur);

                if (0 >= i && i < sm0)
                //kui i on vahemikus 0 ja sm0, 
                { displayableData += "░"; } //siis joonistame tumeda tähemärgi
                else if (sm0 >= i && i < keskPunkt)
                //kui i on vahemikus sm0 ja 45, 
                { displayableData += "░"; } //siis joonistame tumeda tähemärgi
                else if (sm0 >= i && i < keskPunkt * 2)
                //kui i on vahemikus sm0 ja 90, 
                { displayableData += "▓"; } //siis joonistame heleda tähemärgi
                else if (keskPunkt >= i && i < sm0)
                //kui i on vahemikus 45 ja sm0, 
                { displayableData += "▓"; } //siis joonistame heleda tähemärgi
                else if (i >= sm0 && i < keskPunkt)
                //kui i on vahemikus sm0 ja 45, 
                { displayableData += "▓"; }//siis joonistame heleda tähemärgi
                else if (i == keskPunkt)
                {
                    displayableData += "║"; //siis joonistame pulga tähemärgi
                }
                else
                { displayableData += "░"; }
                i++;
            }
            Console.WriteLine(displayableData+" "+ nädalapäevaNimed[nädalapäevaNr][1] + ": " + temperatuur);

            if (nädalapäevaNr == 6)
                nädalapäevaNr = 0;
            else
                nädalapäevaNr++;
        }

        List<string[]> andmebaas = new List<string[]>();

        Console.WriteLine("### ALGUS ###");
        string tegevus = String.Empty;
        do
        {
            Console.Write("Vali tegevus [login/register/stop]: ");
            tegevus = Console.ReadLine().ToLower();
            switch (tegevus)
            {
                case "l":
                    Console.WriteLine("### AUTENTIMINE ###");
                    string kasutajaNimi = sisestaIlmaTühikuta("Palun sisesta oma kasutajanimi: ");
                    string parool = sisestaIlmaTühikuta("Palun sisesta oma parool: ");
                    foreach (var konto in andmebaas)
                    {
                        if (konto[0] == kasutajaNimi && konto[2] == parool)
                        {
                            string[] täisNimi = konto[1].Split(' ');
                            Console.WriteLine("Tere tulemast " + täisNimi[0] + "!");

                            do
                            {

                            }
                            while (sisestaIlmaTühikuta("Soovid jätkata [jah/ei]: ") != "ei");
                            break;
                        }
                    }
                    Console.WriteLine("Sellist kontot minu andmebaasis pole.");
                    break;
                case "r":
                    Console.WriteLine("### REGISTREERIMINE ###");
                    string[] uusKonto = new string[3];
                    uusKonto[1] = sisestaTäisnimi();
                    uusKonto[0] = sisestaIlmaTühikuta("Sisesta soovitud kasutajanimi: ");
                    uusKonto[2] = sisestaIlmaTühikuta("Sisesta soovitud parool: ");
                    andmebaas.Add(uusKonto);
                    break;
                case "s":
                    Console.WriteLine("### LÕPP ###");
                    break;
                default:
                    break;
            }
        } while (tegevus != "s");

    }
    public static string sisestaTäisnimi()
    {
        string[] täisNimeOsad = Array.Empty<string>();
        do
        {
            Console.Write("Sisesta oma ees-ja perekonnanimi: ");
            täisNimeOsad = Console.ReadLine().Trim().Split(' ');
            if (täisNimeOsad.Length == 2)
            {
                täisNimeOsad[0] = nimeVormindus(täisNimeOsad[0]);
                täisNimeOsad[1] = nimeVormindus(täisNimeOsad[1]);
            }

        }
        while (täisNimeOsad.Length != 2);
        return täisNimeOsad[0] + " " + täisNimeOsad[1];
    }

    public static string nimeVormindus(string nimi)
    {
        return nimi.Substring(0, 1).ToUpper() + nimi.Substring(1).ToLower();
    }

    public static string sisestaIlmaTühikuta(string tekst)
    {
        string sisestus = String.Empty;
        do
        {
            Console.Write(tekst);
            sisestus = Console.ReadLine().Trim();
        }
        while (string.IsNullOrEmpty(sisestus) || sisestus.Contains(' '));
        return sisestus;
    }

    public static int sisestaTäisArv(string tekst)
    {
        bool kontroll = false;
        int sisestus = -1;
        do
        {
            Console.Write(tekst);
            kontroll = int.TryParse(Console.ReadLine(), out sisestus);
        }
        while (!kontroll || sisestus < 1);
        return sisestus;
    }

    public static double sisestaTemp(string tekst)
    {
        bool kontroll = false;
        double sisestus = -1;
        do
        {
            Console.Write(tekst);
            kontroll = double.TryParse(Console.ReadLine(), out sisestus);
        }
        while (!kontroll);
        return sisestus;
    }

    public static int sisestaNädalapäevaTunnus(string tekst)
    {
        string sisestus = String.Empty;
        List<string> nädalapäevaTunnused = new List<string>(7) { "E", "T", "K", "N", "R", "L", "P" };
        do
        {
            Console.Write(tekst);
            sisestus = Console.ReadLine().Trim().ToUpper();
        }
        while (string.IsNullOrEmpty(sisestus) || !nädalapäevaTunnused.Contains(sisestus));
        return nädalapäevaTunnused.IndexOf(sisestus);
    }
}
