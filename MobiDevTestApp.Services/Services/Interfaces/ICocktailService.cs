using MobiDevTestApp.ViewModels.Requests;
using MobiDevTestApp.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.BusinessLayer.Services.Interfaces
{
    public interface ICocktailService
    {
        Task<List<GetAllCocktailsResponseModel>> GetAll();
        Task AddCocktail(AddCocktailRequestModel cocktail);
        Task DeleteCocktail(long selectedCocktail);
        Task EditCocktail(EditCocktailRequestModel editCocktail);
    }
}
