namespace Business.Services.Factories
{
    using Business.Services.Services;
    using Model.Domain;

    public class TurtleChallengeAlgorithmFactory : ITurtleChallengeAlgorithmFactory
    {
        public ITurtleChallengeAlgorithm GetAlgorithm(GameSettings gameSettings)
            => new TurtleChallengeAlgorithm(gameSettings);
    }
}
