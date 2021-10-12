namespace Business.Services.Factories
{
    using Business.Services.Services;

    public class TurtleChallengeAlgorithmFactory : ITurtleChallengeAlgorithmFactory
    {
        public ITurtleChallengeAlgorithm GetAlgorithm()
            => new TurtleChallengeAlgorithm();
    }
}
