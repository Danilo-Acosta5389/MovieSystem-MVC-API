using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSystem_MVC_API.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public int Year { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        [JsonIgnore]
        public virtual Genre? Genre { get; set; } //This creates Foreignkey Genre_GenreId in Movie table

    }
}
