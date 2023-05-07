using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem_MVC_API.Models
{
    public class TMDBMovie : IEntity
    {
        public int Id { get; set; } 

        public string Title { get; set; }


    }
}
