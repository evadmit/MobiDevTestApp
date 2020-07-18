using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MobiDevTestApp.BusinessLayer.Services;
using MobiDevTestApp.BusinessLayer.Services.Interfaces;
using MobiDevTestApp.DataLayer;
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
            services.AddTransient<ICocktailService, CocktailService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void EnsureUpdate(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            var applicationDbContext = serviceProvider.GetService<ApplicationDbContext>();

            applicationDbContext.Database.EnsureCreated();
        }

    }
}
