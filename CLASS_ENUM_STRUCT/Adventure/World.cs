namespace Adventure
{
    public class World
    {
        public int[,] Map;
        public string WorldName;
        public LocationType Start;
        public LocationType Goal;


        /// <summary>
        /// Constructor for world object with size of 10x0
        /// </summary>
        /// <param name="worldName">Name for this world</param>
        /// <param name="start">Where the player is spawned at</param>
        /// <param name="goal">Where the player finishes the game</param>
        public World(string worldName, LocationType start, LocationType goal)
        {
            Map = NewMap(10, 6);
            WorldName = worldName;
            Start = start;
            Goal = goal;
        }

        /// <summary>
        /// Method to randomly generate new map
        /// </summary>
        /// <param name="size">The size of the map using X and Y axis</param>
        /// <param name="maxEventInteger">Total event count</param>
        /// <returns></returns>
        private int[,] NewMap(int size, int maxEventInteger)
        {
            int[,] newMap = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newMap[i,j] = random.Next(1, maxEventInteger);
                }
            }
            return newMap;
        }
    }
}
