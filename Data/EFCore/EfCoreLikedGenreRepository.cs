using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class EfCoreLikedGenreRepository : EfCoreRepository<LikedGenre, MovieSystem_MVC_APIContext>
    {
        public EfCoreLikedGenreRepository(MovieSystem_MVC_APIContext context) : base(context)
        {

        }
    }
}
