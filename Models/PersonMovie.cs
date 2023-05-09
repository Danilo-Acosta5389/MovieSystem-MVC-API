using MessagePack;
using Microsoft.Build.Framework;
using MovieSystem_MVC_API.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSystem_MVC_API.Models
{
    public class PersonMovie : IEntity
    {
        public int Id { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        [JsonIgnore]
        public Person? Person { get; set; } //This creates Foreignkey Person_PersonId in in the PersonMovie table

        //[ForeignKey("Genre")]
        //public int GenreId { get; set; }

        //[JsonIgnore]
        //public Genre? Genre { get; set; } //Foreignkey to GenreId

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [JsonIgnore]
        public Movie? Movie { get; set; } //Foreignkey to MovieId

        [Required]
        public int Rating { get; set; }

        [Required]
        public string? Link { get; set; }

    }
}
