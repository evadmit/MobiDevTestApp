using FluentValidation;
using MobiDevTestApp.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobiDevTestApp.Api.Validators
{
    public class AddIngredientRequestModelValidator: AbstractValidator<AddIngredientRequestModel>
    {
        public AddIngredientRequestModelValidator()
        {
            RuleFor(x => x.Title).NotEmpty().Matches("[a-zA-Z]{3,30}");
            RuleFor(x => x.MeasurmentId).NotNull().GreaterThan(0).WithMessage("Measurment is required.");
        }
    }
}
