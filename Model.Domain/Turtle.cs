namespace Model.Domain
{
    using Model.Domain.Exceptions;

    using System;

    public class Turtle
    {
        public Tuple<int, int> Position { get; private set; }
        public string Orientation { get; private set; }

        public Turtle(GameSettings gameSettings)
        {
            this.Position = gameSettings.StartingPoint;
            this.Orientation = gameSettings.StartingDirection;
        }

        public Tuple<int, int> Move()
        {
            this.Position = this.Orientation switch
            {
                Directions.NORTH => new Tuple<int, int>(this.Position.Item1 - 1, this.Position.Item2),
                Directions.EAST => new Tuple<int, int>(this.Position.Item1, this.Position.Item2 + 1),
                Directions.SOUTH => new Tuple<int, int>(this.Position.Item1 + 1, this.Position.Item2),
                Directions.WEST => new Tuple<int, int>(this.Position.Item1, this.Position.Item2 - 1),
                _ => throw new HandledException($"Wrong Orientation set on Turtle: {this.Orientation}"),
            };
            return this.Position;
        }

        public void Rotate()
        {
            this.Orientation = this.Orientation switch
            {
                Directions.NORTH => Directions.EAST,
                Directions.EAST => Directions.SOUTH,
                Directions.SOUTH => Directions.WEST,
                Directions.WEST => Directions.NORTH,
                _ => throw new HandledException($"Wrong Orientation set on Turtle: {this.Orientation}"),
            };
        }
    }
}
