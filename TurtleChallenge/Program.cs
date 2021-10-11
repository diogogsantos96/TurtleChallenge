namespace TurtleChallenge
{
    using Business.Services.Factories;
    using Model.Domain;
    using Model.Domain.Parsers;
    using System;
    using TurtleChallenge.FileReaders;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gameSettings = new JsonReader<GameSettings>().Read(args[0]);
                var moves = new TextReader().Read(args[1]);
                var movesList = MovesParser.Parse(moves);

                var service = new TurtleChallengeAlgorithmFactory().GetAlgorithm(gameSettings);
                service.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ups! Something went wrong: {ex.Message}");
            }
        }
    }
}
