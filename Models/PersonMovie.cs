namespace MovieSystem_MVC_API.Models
{
    public class PersonMovie
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int GenreId { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
        public string? Link { get; set; }


        public virtual List<Person> Persons { get; set; }
        public virtual List<Genre>  Genres { get; set; }
        public virtual List<Movie> Movies { get; set;}
    }
}
