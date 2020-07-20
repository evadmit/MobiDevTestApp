using AutoMapper;
using MobiDevTestApp.BusinessLayer.Services.Interfaces;
using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using MobiDevTestApp.ViewModels.Requests;
using MobiDevTestApp.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.BusinessLayer.Services
{
    public class CocktailService: ICocktailService
    {
        private readonly ICocktailRepository _cocktailRepository;
        private readonly IIngredientRepository _ingredientRepository;

        private IMapper _mapper;
        public CocktailService(ICocktailRepository cocktailRepository, IIngredientRepository ingredientRepository, IMapper mapper)
        {
            _cocktailRepository = cocktailRepository;
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }

        public async Task AddCocktail(AddCocktailRequestModel cocktail)
        {
            var newCocktail = _mapper.Map<Cocktail>(cocktail);
            await _cocktailRepository.Add(newCocktail);
        }

        public async Task AddIngredient(AddIngredientRequestModel addIngredient)
        {
            var newIngredient = _mapper.Map<Ingredient>(addIngredient);
            await _ingredientRepository.Add(newIngredient);
        }

        public Task DeleteCocktail(long selectedCocktail)
        {
            throw new NotImplementedException();
        }

        public Task EditCocktail(EditCocktailRequestModel editCocktail)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetAllCocktailsResponseModel>> GetAll()
        {
            var cocktails = await _cocktailRepository.GetCocktailsWithIngredients();
            var mappedCocktails = _mapper.Map<List<GetAllCocktailsResponseModel>>(cocktails);
            return mappedCocktails;
        }
    }
}
