using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSystem_MVC_API.Models
{
    public class LikedGenre : IEntity
    {
        public int Id { get; set; }

        //public string Name { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        [JsonIgnore]
        public Genre? Genre { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [JsonIgnore]
        public Person? Person { get; set; }
    }
}
