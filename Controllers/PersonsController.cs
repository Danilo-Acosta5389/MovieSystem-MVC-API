using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieSystem_MVC_API.Data.EFCore;
using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : MovieSystem_MVC_APIController<Person, EfCorePersonRepository>
    {
        public PersonController(EfCorePersonRepository repository) : base(repository)
        {

        }
    }
}
