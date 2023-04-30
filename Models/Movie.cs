using System.ComponentModel.DataAnnotations;

namespace MovieSystem_MVC_API.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        public Genre Genre { get; set; } //This creates Foreignkey Genre_GenreId in Db
    }
}
