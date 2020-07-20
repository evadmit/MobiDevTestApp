using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Entities
{
    public class CocktailIngredient
    {
        public long CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }

        public long IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
