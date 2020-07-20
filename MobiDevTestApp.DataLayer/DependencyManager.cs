using Microsoft.Extensions.DependencyInjection;
using MobiDevTestApp.DataLayer.Repositories;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;

namespace MobiDevTestApp.DataLayer
{
    public class DependencyManager
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IMeasurmentRepository, MeasurmentRepository>();
            services.AddTransient<ICocktailRepository, CocktailRepository>();

        }
    }
}
