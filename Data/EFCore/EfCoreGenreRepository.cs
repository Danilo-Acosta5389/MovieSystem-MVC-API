using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class EfCoreGenreRepository : EfCoreRepository<Genre, MovieSystem_MVC_APIContext>
    {
        public EfCoreGenreRepository(MovieSystem_MVC_APIContext context) : base(context)
        {

        }
    }
}
