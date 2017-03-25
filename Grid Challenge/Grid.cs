namespace GridChallenge
{
    class Grid
    {
        public int XMin { get; set; }
        public int YMin { get; set; }
        public int XMax { get; set; }
        public int YMax { get; set; }
        public Grid(Coordinates gridStartCoords, Coordinates gridEndCoords)
        {
            XMin = gridStartCoords.x;
            YMin = gridStartCoords.y;
            XMax = gridEndCoords.x;
            YMax = gridEndCoords.y;
        }
    }
}
