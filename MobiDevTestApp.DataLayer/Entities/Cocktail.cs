using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Entities
{
    public class Cocktail: BaseEntity
    {
        public decimal Price { get; set; }
        public IList<CocktailIngredient> CocktailIngredients { get; set; }
    }
}
