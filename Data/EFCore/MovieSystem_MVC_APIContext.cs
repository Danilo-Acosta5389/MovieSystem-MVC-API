﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieSystem_MVC_API.Models;

namespace MovieSystem_MVC_API.Data.EFCore
{
    public class MovieSystem_MVC_APIContext : DbContext
    {
        public MovieSystem_MVC_APIContext(DbContextOptions<MovieSystem_MVC_APIContext> options)
            : base(options)
        {
        }


        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<LikedGenre> LikedGenre { get; set; } = default!;
        public DbSet<PersonMovie> PersonMovie { get; set; } = default!;

    }
}
