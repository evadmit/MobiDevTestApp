using FluentValidation;
using MobiDevTestApp.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobiDevTestApp.Api.Validators
{
    public class EditCocktailRequestModelValidator: AbstractValidator<EditCocktailRequestModel>
    {
        public EditCocktailRequestModelValidator()
        {
            RuleFor(x => x.Id).NotNull().GreaterThan(0);
            RuleFor(x => x.Ingredients).NotNull().WithMessage("Ingredients are required.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(x => x.Price).NotNull().GreaterThan(5).WithMessage("Min price is 5.");
        }
    }
}
