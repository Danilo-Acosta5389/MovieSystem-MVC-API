using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MovieSystem_MVC_APIContext>
    {
        public EfCoreMovieRepository(MovieSystem_MVC_APIContext context) : base(context)
        {

        }
    }
}
