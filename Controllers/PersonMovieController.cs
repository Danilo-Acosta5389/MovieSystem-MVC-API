using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using MovieSystem_MVC_API.Data;
using NuGet.Protocol.Core.Types;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonMovieController : ControllerBase
    {
        private readonly MovieSystem_MVC_APIContext context;

        public PersonMovieController(MovieSystem_MVC_APIContext context)
        {
            this.context = context;
        }

        [HttpGet("PersonId")]
        public async Task<ActionResult<List<PersonMovie>>> Get(int personId)
        {
            var PersonMovies = await context.PersonMovie
                .Where(c => c.PersonId == personId)
                .ToListAsync();
            return PersonMovies;
        }

        [HttpPost]
        public async Task<ActionResult<PersonMovie>> Post(PersonMovie PersonMovies)
        {
            context.PersonMovie.Add(PersonMovies);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = PersonMovies.Id }, PersonMovies);
        }
    }

}
