namespace Presentation.Console.Output
{
    using Business.Services.Models;

    using System.Collections.Generic;

    public static class AlgorithmResultParser
    {
        private static Dictionary<EAlgorithmResult, string> messages = new Dictionary<EAlgorithmResult, string>()
        {
            { EAlgorithmResult.MineHit, "Mine Hit!"},
            { EAlgorithmResult.OutOfBounds, "Wall Hit!"},
            { EAlgorithmResult.Success, "Success!"},
            { EAlgorithmResult.MineHit, "Still in danger!"},
        };

        public static string Parse(EAlgorithmResult result)
            => messages[result];
    }
}
