using MobiDevTestApp.BusinessLayer.Services.Interfaces;
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
        public Task AddCocktail(AddCocktailRequestModel cocktail)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCocktail(long selectedCocktail)
        {
            throw new NotImplementedException();
        }

        public Task EditCocktail(EditCocktailRequestModel editCocktail)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetAllCocktailsResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
