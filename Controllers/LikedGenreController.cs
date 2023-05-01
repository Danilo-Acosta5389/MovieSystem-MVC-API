﻿using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Models;
using MovieSystem_MVC_API.Data.EFCore;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikedGenreController : MovieSystem_MVC_APIController<LikedGenre, EfCoreLikedGenreRepository>
    {
        public LikedGenreController(EfCoreLikedGenreRepository repository) : base(repository)
        {

        }
    }
}
