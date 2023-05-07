using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using Newtonsoft.Json;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TMDBGetAllGenresId : Controller
    {
        //GET: api/[controller]
        [HttpGet]
        public async Task<IEnumerable<TMDBGetAllGenres>> Get()
        {

            HttpClientHandler httpClientHandler = new HttpClientHandler();

            using (HttpClient client = new HttpClient(httpClientHandler))
            {
                using (var response = await client.GetAsync("https://api.themoviedb.org/3/genre/movie/list?api_key=577f80c6b79d54fd8ea8ce89e551b940&language=en-US"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TMDBGenreResult>(apiResponse).Genres;
                }

            }
        }
    }
}
