using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class CocktailIngredientRepository: BaseRepository<CocktailIngredient>, ICocktailIngredientRepository
    {
        public CocktailIngredientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
