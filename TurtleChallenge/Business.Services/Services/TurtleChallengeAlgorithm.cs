namespace Business.Services.Services
{
    using Model.Domain;

    public class TurtleChallengeAlgorithm : ITurtleChallengeAlgorithm
    {
        private readonly GameSettings gameSettings;

        public TurtleChallengeAlgorithm(GameSettings gameSettings)
        {
            this.gameSettings = gameSettings;
        }

        public void Run(char[] moves)
        {
            throw new System.NotImplementedException();
        }
    }
}
