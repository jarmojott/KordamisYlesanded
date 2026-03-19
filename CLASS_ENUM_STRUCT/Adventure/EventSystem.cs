namespace Adventure
{
    public class EventSystem
    {

        public static void NextEncounter(Player player, World map)
        {
            // LocationType location = player.Location;
            int result = map.Map[player.Location.X, player.Location.Y];
            switch (result)
            {
                case 1:
                    Event1_Kratt(player);
                    break;
                case 2:
                    Event1_Witch(player);
                    break;
                case 3:
                    Event1_Mushroom(player);
                    break;
                case 4:
                    Event1_Knife(player);
                    break;
                case 5:
                    Event1_Hill(player);
                    break;
                case 6:
                    Event1_Shop(player);
                    break;
                default:
                    break;
            }

        }

        public static void NextEncounter(Player player, Random rng)
        {
            int nextEncounterInt = rng.Next(1, 7);
            switch (nextEncounterInt)
            {
                case 1:
                    Event1_Kratt(player);
                    break;
                case 2:
                    Event1_Witch(player);
                    break;
                case 3:
                    Event1_Mushroom(player);
                    break;
                case 4:
                    Event1_Knife(player);
                    break;
                case 5:
                    Event1_Hill(player);
                    break;
                case 6:
                    Event1_Shop(player);
                    break;
                default:
                    break;
            }
        }

        private static void Event1_Shop(Player player)
        {
            List<BackPackItemType> shelf = new List<BackPackItemType>()
                {
                BackPackItemType.katkineSaabas,
                BackPackItemType.mingiLambipirn,
                BackPackItemType.DDR5_32GB_2x16_kit,
                BackPackItemType.Juustukera,
                BackPackItemType.KotitäisLambasoolikaid
                };
            List<int> hinnad = new List<int>()
                {
                    1000,
                    12,
                    1600,
                    3,
                    -6,
                };
            for (int i = 0; i < shelf.Count; i++)
            {
                //kuva kasutajale asi, selle hind
                Console.WriteLine($"Riiulil paistab {shelf[i]} ning see maksab {hinnad[i]}.");
                Console.WriteLine("Kas sa tahad seda osta? (jah/ei)");
                string vastus = Console.ReadLine();
                if (vastus == "jah")
                {
                    if (hinnad[i] < player.Money)
                    {
                        player.Backpack.Add(shelf[i]);
                        player.Money -= hinnad[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sul pole piisavalt raha selle jaoks, vaata midagi muud.");
                    }
                }
                else
                {
                    Console.WriteLine("Vaatad järgmist asja");
                }
                // küsi vastust, kas tahab või ei
                // kui ja, siis lisa asi seljakotti, ja võta raha maha, tsükkel breakib, ja kasutaja lahkub poest
                // kui ei, näita järgmist asja

            }
            Console.WriteLine("Lahkusid poest");
        }

        private static void Event1_Hill(Player player)
        {
            Console.WriteLine("Kõnnid mööda teed, ja vastu tuleb huvtava kujuga põlvekõrgune mätas");
            Console.WriteLine("Mätas on keset teed ees, ei saa ei üle ega ümber sest oled laisk, mida teed?");
            Console.WriteLine("1 - ronin üle\n2 - kaevan lahti\n3 - pööran ringi ja lähen tagasi");
            Console.WriteLine("kirjuta vastava valiku number");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    Console.WriteLine("Ronid mättast üle, ja jätkad oma teed");
                    break;
                case "2":
                    player.Money += 5;
                    Console.WriteLine("Kaevasid mätta lahti, ja leidsid väikese rahapaja, seal oli viis münti.");
                    break;
                default:
                    Console.WriteLine("Hakkasid kannapealt ringi pöörama, kui sellel hetkel kargas mätta\n" +
                        "tagant tuttav kratt, ja peksis sind natuke, kaotasid ühe elu.");
                    player.Lives -= 1;
                    break;
            }
        }

        private static void Event1_Knife(Player player)
        {
            Console.WriteLine("Leiad maast noa, ta on verine, kas sa võtad selle üles?:");
            string response = Console.ReadLine();
            if (response == "jah")
            {
                Console.WriteLine("Panid noa seljakotti");
                player.Backpack.Add(BackPackItemType.Nuga);
            }
            else
            {
                Console.WriteLine("Kõndisid minema, las politsei uurib");
            }
        }

        private static void Event1_Mushroom(Player player)
        {
            Random newrng = new Random();
            int mushroomEffect = newrng.Next(-4, 4);
            Console.WriteLine("Leiad seene, kas tahad seda maitsta?:");
            string response = Console.ReadLine();
            if (response == "jah")
            {
                if (mushroomEffect >= 0)
                {
                    Console.WriteLine("Seen maitses hästi, said juurde " + mushroomEffect + " elu.");
                }
                else
                {
                    Console.WriteLine("Kurat, sitaseen oli, tunned ennast väga pahasti ja kaotasid " + (-mushroomEffect) + " elu.");
                }
                player.Lives += mushroomEffect;
            }
            else
            {
                Console.WriteLine("Jätad seene maha nagu oma abusivi eksi.");

            }
        }

        private static void Event1_Witch(Player player)
        {
            Console.WriteLine("NYEH! Oled eksinud minu koju! Mis sul - sissetungijal - öelda on!!!");
            string response = Console.ReadLine();
            if (response.ToLower() == "palun vabandust")
            {
                Console.WriteLine("No olgu, eks sa mine siis...");
            }
            else if (response.ToLower() == "tahtsin sulle kooki tuua")
            {
                Console.WriteLine("Oi aitäh, anna sulle ühe elu selle koogi vastu");
                player.Lives += 1;
            }
            else
            {
                Console.WriteLine("MISASJA!?!?!?? KUIDAS SA JULGED?!?! KÄI ISE " + response);
                player.Lives -= 1;
            }
        }

        private static void Event1_Kratt(Player player)
        {
            Random newrng = new Random();
            int generation = newrng.Next(1, 10);

            if (!player.Backpack.Contains(BackPackItemType.Nuga))
            {
                Console.WriteLine("Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!"); //flavourtext
                Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                int kasutajaArv = int.Parse(Console.ReadLine());

                if (generation == kasutajaArv) // kontrolli sisestust tingimuslauses
                {
                    Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                }
                else
                {
                    Console.WriteLine("HJEHJEHJEH - õige vastus oli" + generation + "!!!! sa kaotasid!"); //kui on vale
                    player.Lives -= 1;
                }
            }
            else
            {
                Console.WriteLine("Vastu tuleb kuri kratt, aga sul on nuga. Kratt ütleb:");
                Console.WriteLine("\"Hahaaa, olen kuri kratt, aga sa saad minust jagu, kui arvad ära, \n mitme vanaeide käed ma olen otsast ära söönud!\"");
                Console.WriteLine("Mida sa teed? Kas vastad (1) või ründad noaga (2)?");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    Console.WriteLine("Arva:"); //oota kasutajalt sisestust
                    int kasutajaArv = int.Parse(Console.ReadLine());

                    if (generation == kasutajaArv) // kontrolli sisestust tingimuslauses
                    {
                        Console.WriteLine("AIAIAIAAA, Y U DIS TO ME *sureb*"); //kui on õige
                    }
                    else
                    {
                        Console.WriteLine("HJEHJEHJEH - õige vastus oli" + generation + "!!!! sa kaotasid!"); //kui on vale
                        player.Lives -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Lõikasid krati lõhki, ta maost voolas välja 25 münti!\nAga nuga murdus...");
                    player.Money += 25;
                    player.Backpack.Remove(BackPackItemType.Nuga);
                }
            }
        }

        public static void NextLocation(Player player, World map)
        {
            int mapXmax = map.Map.GetLength(0) - 1;
            int mapYmax = map.Map.GetLength(1) - 1;
            Console.WriteLine("Vali suund tähega:");
            Console.WriteLine("   N   ");
            Console.WriteLine("W  +  E");
            Console.WriteLine("   S   ");
            string response = Console.ReadLine().ToUpper();

            int nextLocation;
            switch (response)
            {
                case "N":
                    nextLocation = checkCandidate(mapYmax, player.Location.Y - 1, true);
                    player.Location = new LocationType(player.Location.X, nextLocation);
                    break;
                case "S":
                    nextLocation = checkCandidate(mapYmax, player.Location.Y + 1);
                    player.Location = new LocationType(player.Location.X, nextLocation);
                    break;
                case "W":
                    nextLocation = checkCandidate(mapXmax, player.Location.X - 1, true);
                    player.Location = new LocationType(nextLocation, player.Location.Y);
                    break;
                case "E":
                    nextLocation = checkCandidate(mapXmax, player.Location.X + 1);
                    player.Location = new LocationType(nextLocation, player.Location.Y);
                    break;
            }

        }

        /// <summary>
        /// Checks if player next location exceeds maximum value.
        /// </summary>
        /// <param name="maxValue">Value to compare against</param>
        /// <param name="playerNextLocation">Players future location</param>
        /// <returns>Returns 0 if exceeded or player future location </returns>
        private static int checkCandidate(int maxValue, int playerNextLocation, bool checkMinimum = false)
        {
            if (!checkMinimum)
            {
                if (playerNextLocation > maxValue)
                    return 0;
                else
                    return playerNextLocation;
            }
            else
            {
                if (playerNextLocation > maxValue)
                    return maxValue;
                else
                    return playerNextLocation;
            }

        }

        internal static bool CheckWin(LocationType location, LocationType goal)
        {
            if (location.ToString() == goal.ToString())
            {
                return true;
            }
            else
                return false;

        }
    }
}
