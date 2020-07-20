using FluentValidation;
using MobiDevTestApp.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobiDevTestApp.Api.Validators
{
    public class EditIngredientRequestModelValidator: AbstractValidator<EditIngredientRequestModel>
    {
        public EditIngredientRequestModelValidator()
        {
            RuleFor(x => x.Id).NotNull().GreaterThan(0);
            RuleFor(x => x.MeasurmentId).NotNull().GreaterThan(0).WithMessage("MeasurmentId is required.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
        }
    }
}
