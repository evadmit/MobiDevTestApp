using FluentValidation;
using MobiDevTestApp.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobiDevTestApp.Api.Validators
{
    public class AddCocktailRequestModelValidator: AbstractValidator<AddCocktailRequestModel>
    {
        public AddCocktailRequestModelValidator()
        {
            RuleFor(x => x.Title).NotEmpty().Matches("[a-zA-Z]{3,30}");
            RuleFor(x => x.Ingredients).NotNull().WithMessage("Ingredients are required.");
            RuleFor(x => x.Price).NotNull().GreaterThan(5).WithMessage("Min price is 5.");
        }
    }
}
