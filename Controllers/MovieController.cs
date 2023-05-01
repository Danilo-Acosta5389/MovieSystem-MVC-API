using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : MovieSystem_MVC_APIController<Movie, EfCoreMovieRepository>
    {
        public MovieController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
