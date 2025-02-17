﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.ViewModels.Responses
{
    public class ErrorResponseModel
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }

    public class ErrorModel
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
