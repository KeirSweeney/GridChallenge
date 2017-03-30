namespace GridChallenge
{
    /// <summary>
    /// Holds the properties of a start and end coordinate pair.
    /// </summary>
    class Grid
    {
        public Coordinate CoordMin { get; set; }
        public Coordinate CoordMax { get; set; }
        public Grid(Coordinate gridStartCoords, Coordinate gridEndCoords)
        {
            CoordMin = new Coordinate { X = gridStartCoords.X, Y = gridStartCoords.Y };
            CoordMax = new Coordinate { X = gridEndCoords.X, Y = gridEndCoords.Y };
        }
    }
}
