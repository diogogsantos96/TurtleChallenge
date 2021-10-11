namespace Model.Domain
{
    using System;
    using System.Collections.Generic;

    public class GameSettings
    {
        public Tuple<int, int> BoardSize { get; set; }
        public Tuple<int, int> StartingPoint { get; set; }
        public string Direction { get; set; }
        public Tuple<int, int> ExitPoint { get; set; }
        public HashSet<Tuple<int, int>> Mines { get; set; }

        public GameSettings()
        {

        }
    }
}
