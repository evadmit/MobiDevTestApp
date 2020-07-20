using AutoMapper;
using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.ViewModels.Requests;
using MobiDevTestApp.ViewModels.Responses;

namespace MobiDevTestApp.BusinessLayer
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Ingredient, GetAllIngredientsResponseModel>().ReverseMap();
            CreateMap<Ingredient, CocktailIngredient>().ReverseMap();
            CreateMap<Ingredient, AddIngredientRequestModel>()
                .ForMember(ai => ai.MeasurmentId, i => i.MapFrom(src => src.MeasurmentId))
                .ReverseMap();
            CreateMap<Ingredient, IngredientIdRequestModel>()
                .ForMember(ai => ai.Id, i => i.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<Ingredient, EditIngredientRequestModel>()
                .ForMember(ai => ai.Id, i => i.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<IngredientIdRequestModel, CocktailIngredient>()
                .ForMember(ai => ai.IngredientId, i => i.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<CocktailIngredient, GetAllIngredientsResponseModel>()
                .ForMember(ci => ci.Title, gai => gai.MapFrom(src => src.Ingredient.Title))
                .ForMember(ci => ci.Measurment, gai => gai.MapFrom(src => src.Ingredient.Measurment))
                .ReverseMap();
            CreateMap<CocktailIngredient, AddIngredientRequestModel>()
                .ForMember(ci => ci.Title, gai => gai.MapFrom(src => src.Ingredient.Title))
                .ForMember(ci => ci.MeasurmentId, gai => gai.MapFrom(src => src.Ingredient.MeasurmentId))
                .ReverseMap();
            CreateMap<CocktailIngredient, EditIngredientRequestModel>()
                .ForMember(ci => ci.Title, gai => gai.MapFrom(src => src.Ingredient.Title))
                .ForMember(ci => ci.MeasurmentId, gai => gai.MapFrom(src => src.Ingredient.MeasurmentId))
                .ReverseMap();

            CreateMap<Measurment, GetAllMeasurmentsResponseModel>().ReverseMap();

            CreateMap<Cocktail, AddCocktailRequestModel>()
                .ForMember(ad => ad.Ingredients, c => c.MapFrom(src => src.CocktailIngredients))
                .ReverseMap();
            CreateMap<Cocktail, EditCocktailRequestModel>()
                .ForMember(ad => ad.Ingredients, c => c.MapFrom(src => src.CocktailIngredients))
                .ReverseMap();
            CreateMap<Cocktail, GetAllCocktailsResponseModel>()
                .ForMember(ct => ct.Ingredients, gac => gac.MapFrom(src => src.CocktailIngredients))
                .ReverseMap();
        }
    }
}
