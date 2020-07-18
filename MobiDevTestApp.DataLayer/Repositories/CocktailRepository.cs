using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class CocktailRepository: BaseRepository<Cocktail>, ICocktailRepository
    {
        public CocktailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
