using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ILogger<CocktailController> _logger;

        public CocktailController(ICocktailService cocktailService, ILogger<CocktailController> logger)
        {
            _cocktailService = cocktailService;
            _logger = logger;
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
        public async Task<IActionResult> EditCoktail([FromBody]EditCocktailRequestModel editCocktail)
        {
            await _cocktailService.EditCocktail(editCocktail);
            return Ok();
        }

        [HttpPost]
        [Route("delete/{cocktailId}")]
        public async Task<IActionResult> Delete(long cocktailId)
        {
            await _cocktailService.DeleteCocktail(cocktailId);
            return Ok();
        }
    }
}
