namespace TurtleChallenge
{
    using Business.Services.Factories;

    using Model.Domain;
    using Model.Domain.Parsers;

    using Presentation.Console.Output;

    using System;

    using TurtleChallenge.Input;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gameSettings = new JsonReader<GameSettings>().Read(args[0]);
                var moves = new TextReader().Read(args[1]);
                var movesList = MovesParser.Parse(moves);

                var service = new TurtleChallengeAlgorithmFactory().GetAlgorithm();
                var result = service.RunAsync(gameSettings, movesList).GetAwaiter().GetResult();

                new ConsoleOutputWriter().Write(AlgorithmResultParser.Parse(result));
            }
            catch (Exception ex)
            {
                new ConsoleOutputWriter().Write($"Ups! Something went wrong: {ex.Message}");
            }
        }
    }
}
