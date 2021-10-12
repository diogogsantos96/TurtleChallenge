namespace Business.Services.Services
{
    using Business.Services.Models;

    using Model.Domain;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITurtleChallengeAlgorithm
    {
        Task<EAlgorithmResult> RunAsync(GameSettings gameSettings, IEnumerable<char> moves);
    }
}
