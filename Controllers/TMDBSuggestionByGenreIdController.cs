using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using Newtonsoft.Json;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TMDBSuggestionByGenreIdController : Controller
    {

        //GET: api/[controller]
        [HttpGet("id")]
        public async Task<IEnumerable<TMDBMovie>> Get(int id)
        {

            HttpClientHandler httpClientHandler = new HttpClientHandler();

            using (HttpClient client = new HttpClient(httpClientHandler))
            {

                using (var response = await client.GetAsync($"https://api.themoviedb.org/3/discover/movie?api_key=577f80c6b79d54fd8ea8ce89e551b940&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&with_watch_monetization_types=flatrate&with_genres={id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TMDBMovieResult>(apiResponse).Results;
                }

            }


        }

    }
    
}
