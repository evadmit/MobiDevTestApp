using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Entities
{
    public class Ingredient: BaseEntity
    {
        public long MeasurmentId { get; set; }
        public Measurment Measurment { get; set; }
        public IList<CocktailIngredient> CocktailIngredients { get; set; }
    }
}
