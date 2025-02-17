﻿using AutoMapper;
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

        private IMapper _mapper;
        public CocktailService(ICocktailRepository cocktailRepository, IMapper mapper)
        {
            _cocktailRepository = cocktailRepository;
            _mapper = mapper;
        }

        public async Task AddCocktail(AddCocktailRequestModel cocktail)
        {
            var newCocktail = _mapper.Map<Cocktail>(cocktail);
            await _cocktailRepository.Add(newCocktail);
        }

        public async Task DeleteCocktail(long selectedCocktailId)
        {
            await _cocktailRepository.Delete(selectedCocktailId);
        }

        public async Task EditCocktail(EditCocktailRequestModel editCocktail)
        {
            var cocktailToUpdate = await _cocktailRepository.GetCocktailWithIngredient(editCocktail.Id);
            if (cocktailToUpdate != null)
            {
                cocktailToUpdate.Title = editCocktail.Title;
                cocktailToUpdate.Price = editCocktail.Price;

                var newIngredients = new List<CocktailIngredient>();
                foreach (var ingredient in editCocktail.Ingredients)
                {
                    newIngredients.Add(new CocktailIngredient() { CocktailId = editCocktail.Id, IngredientId = ingredient.Id });
                }
                cocktailToUpdate.CocktailIngredients = newIngredients;

                  await _cocktailRepository.Edit(cocktailToUpdate);
            }
        }

        public async Task<List<GetAllCocktailsResponseModel>> GetAll()
        {
            var cocktails = await _cocktailRepository.GetCocktailsWithIngredients();
            var mappedCocktails = _mapper.Map<List<GetAllCocktailsResponseModel>>(cocktails);
            return mappedCocktails;
        }
    }
}
