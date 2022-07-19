using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyDotnetWebAPI.Models;

namespace StudyDotnetWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleHeroController : ControllerBase
    {
        private static List<PeopleHero> people = new List<PeopleHero>
            {
                new PeopleHero {
                    ID = 1,
                    Name = "黄继光",
                    FamilyName = "黄",
                    GivenName = "继光",
                }
            };


        [HttpGet]
        public async Task<ActionResult<List<PeopleHero>>> Get()
        {
            return Ok(people);
        }
    }
}