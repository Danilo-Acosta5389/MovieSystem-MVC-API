using MovieSystem_MVC_API.Data;

namespace MovieSystem_MVC_API.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
