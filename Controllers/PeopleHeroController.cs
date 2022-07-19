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
                },

                new PeopleHero {
                    ID = 2,
                    Name = "杨根思",
                    FamilyName = "杨",
                    GivenName = "根思",
                }

            };


        [HttpGet]
        public async Task<ActionResult<List<PeopleHero>>> Get()
        {
            return Ok(people);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeopleHero>> Get(int id)
        {
            PeopleHero? person = people.Find(one => one.ID == id);

            if (person == null)
            {
                return BadRequest("Person not found.");
            }

            return Ok(person);
        }


        [HttpPost]
        public async Task<ActionResult<List<PeopleHero>>> AddPerson(PeopleHero person)
        {
            people.Add(person);
            return Ok(people);
        }

        [HttpPut]
        public async Task<ActionResult<List<PeopleHero>>> UpdatePerson(PeopleHero request)
        {
            PeopleHero? person = people.Find(one => one.ID == request.ID);

            if (person == null)
            {
                return BadRequest("Person not found.");
            }

            person.Name = request.Name;
            person.FamilyName = request.FamilyName;
            person.GivenName = request.GivenName;

            return Ok(people);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PeopleHero>>> DeletePerson(int id)
        {
            PeopleHero? person = people.Find(one => one.ID == id);

            if (person == null)
            {
                return BadRequest("Person not found.");
            }

            people.Remove(person);
            return Ok(people);
        }
    }
}