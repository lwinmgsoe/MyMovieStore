using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public LanguagesController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(db.Languages.GetAll());
        }
    }
}
