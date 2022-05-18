using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneresController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public GeneresController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(db.Generes.GetAll());
        }
    }
}
