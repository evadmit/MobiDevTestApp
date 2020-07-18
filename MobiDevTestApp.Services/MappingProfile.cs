using AutoMapper;
using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.BusinessLayer
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Cocktail, AddCocktailRequestModel>().ReverseMap();
        }
    }
}
