namespace NorthWind.Sales.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services){

            services.AddScoped<ICommandsRepository, CommandsRepository>();
            return services;
        }
    }
}