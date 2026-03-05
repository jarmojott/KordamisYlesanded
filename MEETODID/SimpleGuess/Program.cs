internal class Program
{
    static void Main(string[] args)
    {
        Random juhuArv = new Random(); // juhu generaator
        int elud = 3;
        string mängijaMängib = "jah";
        do //tsükkel
        {
            int seeJuhuArv = juhuArv.Next(1, 10); // juhuslik täisarv vahemikus 1-10
            Console.WriteLine("Sul on " + elud + " elu.");
            Console.Write("Arva: ");
            int kasutajaArv = int.Parse(Console.ReadLine()); //oota kasutaja sisestust

            elud = kratt(seeJuhuArv, kasutajaArv, elud);

            elud = seenekas(juhuArv, elud);

            if (elud <= 0)
            {
                Console.Write("Elud otsas, kas soovid uuesti mängida [jah/ei]: ");
                mängijaMängib = Console.ReadLine().ToLower();
                if (mängijaMängib.Equals("jah"))
                {
                    elud = 3;
                    Console.Clear();
                }
            }
        }
        while (mängijaMängib.Equals("jah"));
    }

    private static int seenekas(Random juhuArv, int elud)
    {
        Console.Write("Leiad seene.\nKas otsustad süüa [jah/ei]: ");
        if (Console.ReadLine().ToLower().Equals("jah"))
        {
            int seeneArv = juhuArv.Next(-4, 4);
            Console.WriteLine("Seen annab sulle " + seeneArv + " elu.");
            elud = elud + seeneArv;
        }

        return elud;
    }

    private static int kratt(int seeJuhuArv, int kasutajaArv, int elud)
    {
        if (seeJuhuArv == kasutajaArv)
        {  //kontrolli sisestust
            Console.WriteLine("TUBLI!");
            return elud + 1;
        }
        else
        {
            Console.WriteLine("Õige vastus oli: " + seeJuhuArv);
            return elud - 1;
        }
    }
}
