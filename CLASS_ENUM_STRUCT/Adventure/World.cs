namespace Adventure
{
    internal class World
    {
        public int[,] Map;
        public string WorldName;
        public LocationType Start;
        public LocationType Goal;

        public World(int[,] map, string worldName, LocationType start, LocationType goal)
        {
            Map = map;
            worldName = WorldName;
            Start = start;
            Goal = goal;
        }
    }
}
