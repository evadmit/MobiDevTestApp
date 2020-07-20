using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobiDevTestApp.BusinessLayer.Services.Interfaces;
using MobiDevTestApp.ViewModels.Requests;

namespace MobiDevTestApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly ICocktailService _cocktailService;
        private readonly ILogger<IngredientController> _logger;

        public IngredientController(ICocktailService cocktailService, ILogger<IngredientController> logger)
        {
            _cocktailService = cocktailService;
            _logger = logger;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody]AddIngredientRequestModel addIngredient)
        {

            await _cocktailService.AddIngredient(addIngredient);

            return Ok();
        }
    }
}