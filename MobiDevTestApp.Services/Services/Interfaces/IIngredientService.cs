using MobiDevTestApp.ViewModels.Requests;
using MobiDevTestApp.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.BusinessLayer.Services.Interfaces
{
    public interface IIngredientService
    {

        Task<List<GetAllIngredientsResponseModel>> GetAll();
        Task AddIngredient(AddIngredientRequestModel ingredient);
        Task DeleteIngredient(long selectedIngredientId);
        Task EditIngredient(EditIngredientRequestModel editIngredient);
    }
}
