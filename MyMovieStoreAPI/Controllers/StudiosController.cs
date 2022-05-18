using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudiosController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public StudiosController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Studios.GetAll());
        }
    }
}
