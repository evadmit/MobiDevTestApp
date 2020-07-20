using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.ViewModels.Responses
{
    public class GetAllIngredientsResponseModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public GetAllMeasurmentsResponseModel Measurment { get; set; }
    }
}
