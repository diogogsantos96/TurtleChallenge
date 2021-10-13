namespace TurtleChallenge
{
    using Business.Services.Factories;
    using Microsoft.Extensions.DependencyInjection;
    using Model.Domain;
    using Model.Domain.Parsers;
    using Newtonsoft.Json;
    using Presentation.Console.Bootstrappers;
    using Presentation.Console.Output;

    using System;
    using System.Collections.Generic;
    using TurtleChallenge.Input;

    public class Program
    {
        private static IOutputWriter outputWriter;

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddBusinessDependencies()
                .AddPresentationDependencies()
                .BuildServiceProvider();

            outputWriter = serviceProvider.GetRequiredService<IOutputWriter>();

            try
            {
                var gameSettings = new JsonReader<GameSettings>().Read(args[0]);
                var moves = new JsonReader<IEnumerable<string>>().Read(args[1]);

                var service = serviceProvider.GetRequiredService<ITurtleChallengeAlgorithmFactory>()
                    .GetAlgorithm();

                RunSequences(gameSettings, moves, service);
            }
            catch (Exception ex)
            {
                outputWriter.Write($"Ups! Something went wrong: {ex.Message}");
            }
        }

        private static void RunSequences(GameSettings gameSettings, IEnumerable<string> moves, Business.Services.Services.ITurtleChallengeAlgorithm service)
        {
            int index = 1;

            foreach (var sequence in moves)
            {
                var movesList = MovesParser.Parse(sequence);

                var result = service.RunAsync(gameSettings, movesList).GetAwaiter().GetResult();

                outputWriter.Write($"Sequence {index}: {AlgorithmResultParser.Parse(result)}");
                index++;
            }
        }
    }
}
