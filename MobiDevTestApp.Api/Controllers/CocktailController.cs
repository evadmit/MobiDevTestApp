using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MobiDevTestApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CocktailController> _logger;

        public CocktailController(ILogger<CocktailController> logger)
        {
            _logger = logger;
        }

       
    }
}
