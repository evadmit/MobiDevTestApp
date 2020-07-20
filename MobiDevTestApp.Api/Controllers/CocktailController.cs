using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobiDevTestApp.BusinessLayer.Services.Interfaces;
using MobiDevTestApp.ViewModels.Requests;
using MobiDevTestApp.ViewModels.Responses;

namespace MobiDevTestApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailController : ControllerBase
    {
        private readonly ICocktailService _cocktailService;

        public CocktailController(ICocktailService cocktailService)
        {
            _cocktailService = cocktailService;
        }

        [HttpGet]
        [Route("cocktails")]
        public async Task<ActionResult<List<GetAllCocktailsResponseModel>>> GetAllCocktails()
        {
            List<GetAllCocktailsResponseModel> list = await _cocktailService.GetAll();
            return Ok(list);
        }


        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody]AddCocktailRequestModel addCocktail)
        {
           
            await _cocktailService.AddCocktail(addCocktail);
            return Ok();
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> EditCocktail([FromBody]EditCocktailRequestModel editCocktail)
        {
            await _cocktailService.EditCocktail(editCocktail);
            return Ok();
        }

        [HttpDelete("{cocktailId}")]
        public async Task<IActionResult> Delete([FromRoute]long cocktailId)
        {
            await _cocktailService.DeleteCocktail(cocktailId);
            return Ok();
        }
    }
}
