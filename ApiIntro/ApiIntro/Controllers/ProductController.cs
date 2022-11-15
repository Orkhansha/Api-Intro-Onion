using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetById(int id)
        {
            return "Orxan" + id;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string> { "Seid", "Orxan", "Nermin" };
            return Ok(names);
        }


    }
}
