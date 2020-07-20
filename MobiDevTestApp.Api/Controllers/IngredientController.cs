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
        private readonly IIngredientService _ingredientService;
        private readonly ILogger<IngredientController> _logger;

        public IngredientController(ICocktailService cocktailService, IIngredientService ingredientService, ILogger<IngredientController> logger)
        {
            _cocktailService = cocktailService;
            _ingredientService = ingredientService;
            _logger = logger;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody]AddIngredientRequestModel addIngredient)
        {

            await _ingredientService.AddIngredient(addIngredient);

            return Ok();
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Edit([FromBody]EditIngredientRequestModel editIngredient)
        {

            await _ingredientService.EditIngredient(editIngredient);

            return Ok();
        }

        [HttpDelete("{ingredientId}")]
        public async Task<IActionResult> Delete([FromRoute]long ingredientId)
        {
            await _ingredientService.DeleteIngredient(ingredientId);
            return Ok();
        }
    }
}