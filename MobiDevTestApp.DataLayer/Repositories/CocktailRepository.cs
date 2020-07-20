using Microsoft.EntityFrameworkCore;
using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class CocktailRepository: BaseRepository<Cocktail>, ICocktailRepository
    {
        public CocktailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Cocktail>> GetCocktailsWithIngredients()
        {
            List<Cocktail> cocktails = await _dbContext.Cocktails.Include(ct => ct.CocktailIngredients)
            .ThenInclude(ci => ci.Ingredient)
            .ThenInclude(ms => ms.Measurment)
            .ToListAsync();
            return cocktails;
        }

        public async Task<Cocktail> GetCocktailWithIngredient(long Id)
        {
            var cocktails = await _dbContext.Cocktails       
            .Include(ct => ct.CocktailIngredients)
            .ThenInclude(ci => ci.Ingredient)
            .ThenInclude(ms => ms.Measurment)
            .FirstOrDefaultAsync(ct => ct.Id == Id);
            return cocktails;
        }
    }
}
