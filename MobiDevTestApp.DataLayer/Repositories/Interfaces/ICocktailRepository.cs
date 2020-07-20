using MobiDevTestApp.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories.Interfaces
{
    public interface ICocktailRepository: IBaseRepository<Cocktail>
    {
        Task<List<Cocktail>> GetCocktailsWithIngredients();
        Task<Cocktail> GetCocktailWithIngredient(long Id);
    }
}
