namespace MovieSystem_MVC_API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Year { get; set; }

        public int GenreId{ get; set; }
    }
}
