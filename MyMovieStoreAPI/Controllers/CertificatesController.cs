using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public CertificatesController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Certificates.GetAll());
        }
    }
}
