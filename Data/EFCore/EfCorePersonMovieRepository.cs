using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class EfCorePersonMovieRepository : EfCoreRepository<PersonMovie, MovieSystem_MVC_APIContext>
    {
        public EfCorePersonMovieRepository(MovieSystem_MVC_APIContext context) : base(context)
        {

        }
    }
}
