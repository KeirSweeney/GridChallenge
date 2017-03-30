namespace GridChallenge
{
    /// <summary>
    /// Holds the properties of a start and end coordinate pair.
    /// </summary>
    class Grid
    {
        public int XMin { get; set; }
        public int YMin { get; set; }
        public int XMax { get; set; }
        public int YMax { get; set; }
        public Grid(Coordinate gridStartCoords, Coordinate gridEndCoords)
        {
            XMin = gridStartCoords.X;
            YMin = gridStartCoords.Y;
            XMax = gridEndCoords.X;
            YMax = gridEndCoords.Y;
        }
    }
}
