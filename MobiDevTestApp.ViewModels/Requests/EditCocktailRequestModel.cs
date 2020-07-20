using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.ViewModels.Requests
{
    public class EditCocktailRequestModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<IngredientIdRequestModel> Ingredients { get; set; }
    }
}
