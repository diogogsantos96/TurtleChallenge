namespace Business.Services.Factories
{
    using Business.Services.Services;

    public interface ITurtleChallengeAlgorithmFactory
    {
        ITurtleChallengeAlgorithm GetAlgorithm();
    }
}
