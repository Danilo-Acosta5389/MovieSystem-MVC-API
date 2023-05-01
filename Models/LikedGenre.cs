using MovieSystem_MVC_API.Data;

namespace MovieSystem_MVC_API.Models
{
    public class LikedGenre : IEntity
    {
        public int Id { get; set; }

        public Genre Genre { get; set; }

        public Person Person { get; set; }
    }
}
