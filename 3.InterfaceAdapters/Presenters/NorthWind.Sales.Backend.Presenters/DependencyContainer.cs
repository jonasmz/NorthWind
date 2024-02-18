namespace NorthWind.Sales.Backend.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services){

            services.AddScoped<ICreateOrderOutputPort, CreateOrderPresenter>();
            return services;
        }
    }
}