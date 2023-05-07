using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem_MVC_API.Models
{
    public class TMDBGenreResult
    {
        public List<TMDBGetAllGenres> Genres { get; set; }
    }
}
