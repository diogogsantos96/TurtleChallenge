namespace Model.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class GameSettings
    {
        public Coordinate BoardSize { get; set; }
        public Coordinate StartingPoint { get; set; }
        public string StartingDirection { get; set; }
        public Coordinate ExitPoint { get; set; }
        public HashSet<Coordinate> Mines { get; set; }

        public GameSettings()
        {

        }
    }
}
