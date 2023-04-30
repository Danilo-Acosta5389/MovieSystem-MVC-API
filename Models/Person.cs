using MovieSystem_MVC_API.Data;

namespace MovieSystem_MVC_API.Models
{
    public class Person : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string E_Mail { get; set; }
    }
}
