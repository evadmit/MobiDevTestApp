using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.ViewModels.Responses
{
    public class GetAllCocktailsResponseModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public List<GetAllIngredientsResponseModel> Ingredients { get; set; }
    }
}
