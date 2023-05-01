using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : MovieSystem_MVC_APIController<Genre, EfCoreGenreRepository>
    {
        public GenreController(EfCoreGenreRepository repository) : base(repository)
        {

        }
    }
}
