using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MobiDevTestApp.BusinessLayer.Services;
using MobiDevTestApp.BusinessLayer.Services.Interfaces;
using MobiDevTestApp.DataLayer;
using MobiDevTestApp.DataLayer.Repositories;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.BusinessLayer
{
    public class Startup
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

         
            DependencyManager.Configure(services);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<ICocktailService, CocktailService>();
            services.AddTransient<IDbSeeder, DbSeeder>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void EnsureUpdate(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            var applicationDbContext = serviceProvider.GetService<ApplicationDbContext>();

            var dbSeeder = serviceProvider.GetService<IDbSeeder>();

            applicationDbContext.Database.EnsureCreated();
            dbSeeder.SeedDb().Wait();
        }

    }
}
