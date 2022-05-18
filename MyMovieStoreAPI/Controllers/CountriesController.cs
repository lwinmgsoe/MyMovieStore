using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly UnitOfWork services;

        public CountriesController(UnitOfWork services)
        {
            this.services = services;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(services.Countries.GetAll());
        }
    }
}
