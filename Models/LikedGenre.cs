namespace MovieSystem_MVC_API.Models
{
    public class LikedGenre
    {
        public int LikedGenreId { get; set; }

        public Genre Genre { get; set; }

        public Person Person { get; set; }
    }
}
