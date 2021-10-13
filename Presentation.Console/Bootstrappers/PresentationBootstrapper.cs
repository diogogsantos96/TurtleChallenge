namespace Presentation.Console.Bootstrappers
{
    using Business.Services.Factories;
    using Microsoft.Extensions.DependencyInjection;
    using Presentation.Console.Output;

    public static class PresentationBootstrapper
    {
        public static IServiceCollection AddPresentationDependencies(this IServiceCollection @this)
            => @this.AddScoped<IOutputWriter, ConsoleOutputWriter>();
    }
}
