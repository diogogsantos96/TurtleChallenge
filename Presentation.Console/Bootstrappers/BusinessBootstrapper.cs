namespace Presentation.Console.Bootstrappers
{
    using Business.Services.Factories;
    using Microsoft.Extensions.DependencyInjection;

    public static class BusinessBootstrapper
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection @this)
            => @this.AddScoped<ITurtleChallengeAlgorithmFactory, TurtleChallengeAlgorithmFactory>();
    }
}
