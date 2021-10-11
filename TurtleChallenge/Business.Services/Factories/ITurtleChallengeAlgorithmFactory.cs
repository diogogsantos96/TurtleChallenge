namespace Business.Services.Factories
{
    using Business.Services.Services;
    using Model.Domain;

    public interface ITurtleChallengeAlgorithmFactory
    {
        ITurtleChallengeAlgorithm GetAlgorithm(GameSettings gameSettings);
    }
}
