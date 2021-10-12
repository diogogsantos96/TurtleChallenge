namespace Business.Services.Services
{
    using Business.Services.Models;

    using Model.Domain;
    using Model.Domain.Exceptions;

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TurtleChallengeAlgorithm : ITurtleChallengeAlgorithm
    {
        public TurtleChallengeAlgorithm()
        {
        }

        public Task<EAlgorithmResult> RunAsync(GameSettings gameSettings, IEnumerable<char> moves)
        {
            var turtle = new Turtle(gameSettings);

            foreach (var move in moves)
            {
                if (move == 'r')
                    turtle.Rotate();
                else if (move == 'm')
                {
                    var newPosition = turtle.Move();
                    var result = ValidateNewPosition(gameSettings, newPosition);
                    if (result != EAlgorithmResult.Nothing)
                    {
                        return Task.FromResult(result);
                    }
                }
                else throw new UnhandledException($"Invalid move: {move}");
            }

            return Task.FromResult(EAlgorithmResult.Nothing);
        }

        private EAlgorithmResult ValidateNewPosition(GameSettings gameSettings, Coordinate newPosition)
        {
            if (newPosition.X < 1 || newPosition.X > gameSettings.BoardSize.X ||
               newPosition.Y < 1 || newPosition.Y > gameSettings.BoardSize.Y)
                return EAlgorithmResult.OutOfBounds;

            if (gameSettings.Mines.Contains(newPosition))
                return EAlgorithmResult.MineHit;

            if (newPosition.Equals(gameSettings.ExitPoint))
                return EAlgorithmResult.Success;

            return EAlgorithmResult.Nothing;
        }
    }
}
