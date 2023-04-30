﻿using MessagePack;
using MovieSystem_MVC_API.Data;

namespace MovieSystem_MVC_API.Models
{
    public class PersonMovie : IEntity
    {
        public int Id { get; set; }

        public Person Person { get; set; } //This creates Foreignkey Person_PersonId in in the PersonMovie table

        public Genre Genre { get; set; } //Foreignkey to GenreId

        public Movie Movie { get; set; } //Foreignkey to MovieId

        public int Rating { get; set; }

        public string? Link { get; set; }

    }
}
