using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem_MVC_API.Models
{
    public class TMDBMovieResult
    {
        public List<TMDBMovie> Results { get; set; }
    }
}