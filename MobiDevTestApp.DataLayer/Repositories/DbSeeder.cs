using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class DbSeeder: IDbSeeder
    {

        private readonly IMeasurmentRepository _measurmentRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICocktailRepository _cocktailRepository;


        public DbSeeder(IMeasurmentRepository measurmentRepository, IIngredientRepository ingredientRepository, ICocktailRepository cocktailRepository)
        {
            _measurmentRepository = measurmentRepository;
            _ingredientRepository = ingredientRepository;
            _cocktailRepository = cocktailRepository;
        }

        public async Task SeedDb()
        {
            await CreateMeasurments();
            await CreateIngredients();
            await CreateCocktails();
        }

        private async Task CreateMeasurments()
        {
            int measurmentsCount = await _measurmentRepository.Count();

            if (measurmentsCount == 0)
            {
                await _measurmentRepository.Add(new Measurment()
                {
                    Id = 1,
                    Title = "gr",
                    Amount = 50
                });
                await _measurmentRepository.Add(new Measurment()
                {
                    Id = 2,
                    Title = "ml",
                    Amount = 100
                });
                await _measurmentRepository.Add(new Measurment()
                {
                    Id = 3,
                    Title = "ml",
                    Amount = 75
                });

            }

        }
        private async Task CreateIngredients()
        {
            int ingredientsCount = await _ingredientRepository.Count();

            if (ingredientsCount == 0)
            {
                await _ingredientRepository.Add(new Ingredient()
                {
                    Title = "vodka",
                    MeasurmentId = 1
                });
                await _ingredientRepository.Add(new Ingredient()
                {
                    Title = "tonic",
                    MeasurmentId = 2
                });
                await _ingredientRepository.Add(new Ingredient()
                {
                    Title = "juice",
                    MeasurmentId = 3
                });

            }
        }

        private async Task CreateCocktails()
        {
            int cocktailsCount = await _cocktailRepository.Count();

            if (cocktailsCount == 0)
            {
                await _cocktailRepository.Add(new Cocktail()
                {
                    Title = "traditional",
                    Price = 100
                });
                await _cocktailRepository.Add(new Cocktail()
                {
                    Title = "exotic",
                    Price = 25
                });
                await _cocktailRepository.Add(new Cocktail()
                {
                    Title = "juiceee",
                    Price = 35
                });
            }
        }
       
    }
}
