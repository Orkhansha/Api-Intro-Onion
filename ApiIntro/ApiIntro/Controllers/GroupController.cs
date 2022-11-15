using ApiIntro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group> groups = new List<Group>();

            Group group1 = new()
            {
                Id = 1,
                Name = "P130",
                Capacity = 10,
            };
            Group group2 = new()
            {
                Id = 1,
                Name = "P131",
                Capacity = 20,
            };
            Group group3 = new()
            {
                Id = 1,
                Name = "P133",
                Capacity = 30,
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);

        }
    }
}
