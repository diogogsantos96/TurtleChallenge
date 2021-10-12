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
                var newPosition = turtle.Move();
                var result = ValidateNewPosition(gameSettings, newPosition);
                if (result != EAlgorithmResult.Nothing)
                {
                    return Task.FromResult(result);
                }
            }

            return Task.FromResult(EAlgorithmResult.Nothing);
        }

        private EAlgorithmResult ValidateNewPosition(GameSettings gameSettings, Tuple<int, int> newPosition)
        {
            if (newPosition.Item1 < 1 || newPosition.Item1 > gameSettings.BoardSize.Item1 ||
               newPosition.Item2 < 1 || newPosition.Item2 > gameSettings.BoardSize.Item2)
                return EAlgorithmResult.OutOfBounds;

            if(gameSettings.Mines.Contains(newPosition))
                return EAlgorithmResult.MineHit;

            return EAlgorithmResult.Nothing;
        }
    }
}
