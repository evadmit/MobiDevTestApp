using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.ViewModels.Requests
{
    public class EditIngredientRequestModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long MeasurmentId { get; set; }
    }
}
