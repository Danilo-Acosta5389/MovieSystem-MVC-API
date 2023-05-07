using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;
using MovieSystem_MVC_API.Data;
using NuGet.Protocol.Core.Types;
using Newtonsoft.Json;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //public class GenreController : Controller
    public class GenreController : MovieSystem_MVC_APIController<Genre, EfCoreGenreRepository>
    {
        public GenreController(EfCoreGenreRepository repository) : base(repository)
        {

        }

        // GET: api/[controller]
        //[HttpGet("id")]
        //public async Task<IEnumerable<TMDBMovie>> Get()
        //{

        //    HttpClientHandler httpClientHandler = new HttpClientHandler();

        //    using (HttpClient client = new HttpClient(httpClientHandler))
        //    {

        //        using (var response= await client.GetAsync("https://api.themoviedb.org/3/discover/movie?api_key=577f80c6b79d54fd8ea8ce89e551b940&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&with_watch_monetization_types=flatrate&with_genres=80"))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            return JsonConvert.DeserializeObject<TMDBMovieResult>(apiResponse).Results;
        //        }

        //    }


        //}
    }
}
