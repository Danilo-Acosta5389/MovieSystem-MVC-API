using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MovieSystem_MVC_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LikedGenreController : ControllerBase
    {
        private readonly MovieSystem_MVC_APIContext context;

        public LikedGenreController(MovieSystem_MVC_APIContext context)
        {
            this.context = context;
        }

        [HttpGet("personId")]
        public async Task<ActionResult<List<LikedGenre>>> Get(int personId)
        {
            var LikedGenres = await context.LikedGenre
                .Where(c => c.PersonId == personId)
                .ToListAsync();

            return LikedGenres;
        }


        [HttpPost]
        public async Task<ActionResult<LikedGenre>> Post(LikedGenre LikedGenres)
        {
            context.LikedGenre.Add(LikedGenres);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = LikedGenres.Id }, LikedGenres);
        }

    }
}
