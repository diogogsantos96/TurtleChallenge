namespace Model.Domain
{
    using Model.Domain.Exceptions;

    using System;

    public class Turtle
    {
        public Coordinate Position { get; private set; }
        public string Orientation { get; private set; }

        public Turtle(GameSettings gameSettings)
        {
            this.Position = gameSettings.StartingPoint;
            this.Orientation = gameSettings.StartingDirection;
        }

        public Coordinate Move()
        {
            this.Position = this.Orientation switch
            {
                Directions.NORTH => new Coordinate(this.Position.X - 1, this.Position.Y),
                Directions.EAST => new Coordinate(this.Position.X, this.Position.Y + 1),
                Directions.SOUTH => new Coordinate(this.Position.X + 1, this.Position.Y),
                Directions.WEST => new Coordinate(this.Position.X, this.Position.Y - 1),
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
