using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IUnitOfWork services;

        public DirectorsController(IUnitOfWork services)
        {
            this.services = services;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(services.Directors.GetAll());
        }
    }
}
