using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieSystem_MVC_API.Models
{
    public class MovieSystem_MVC_APIContext : DbContext
    {
        public MovieSystem_MVC_APIContext (DbContextOptions<MovieSystem_MVC_APIContext> options)
            : base(options)
        {
        }

        public DbSet<MovieSystem_MVC_API.Models.Person> Person { get; set; } = default!;
    }
}
