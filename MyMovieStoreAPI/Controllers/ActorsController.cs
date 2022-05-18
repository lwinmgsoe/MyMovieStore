using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public ActorsController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(db.Actors.GetAll());
        }
    }
}
