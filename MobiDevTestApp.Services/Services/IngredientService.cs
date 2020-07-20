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
    public class IngredientService: IIngredientService
    {

        private readonly IIngredientRepository _ingredientRepository;

        private IMapper _mapper;

        public IngredientService(IIngredientRepository ingredientRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }

        public async Task AddIngredient(AddIngredientRequestModel addIngredient)
        {
            var newIngredient = _mapper.Map<Ingredient>(addIngredient);
            await _ingredientRepository.Add(newIngredient);
        }
        public async Task EditIngredient(EditIngredientRequestModel editIngredient)
        {
            var oldIngredient = await _ingredientRepository.Get(editIngredient.Id);
            if (oldIngredient != null)
            {
                var updatedIngredient = _mapper.Map<Ingredient>(editIngredient);
                await _ingredientRepository.Edit(updatedIngredient);
            }
        }
        public async Task DeleteIngredient(long selectedIngredientId)
        {
            await _ingredientRepository.Delete(selectedIngredientId);
        }

        public async Task<List<GetAllIngredientsResponseModel>> GetAll()
        {
            var ingredients = await _ingredientRepository.GetList();
            var mappedIngredients = _mapper.Map<List<GetAllIngredientsResponseModel>>(ingredients);
            return mappedIngredients;
        }
    }
}
