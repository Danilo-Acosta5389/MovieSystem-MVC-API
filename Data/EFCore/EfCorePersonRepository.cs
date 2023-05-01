using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class EfCorePersonRepository : EfCoreRepository<Person, MovieSystem_MVC_APIContext>
    {
        public EfCorePersonRepository(MovieSystem_MVC_APIContext context) : base(context)
        {

        }
    }
}
