using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Dtos;

public class MovieDto//: ObjectType<Movie>

{

    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string? Synopsis { get; set; }

    public string? PosterUrl { get; set; }

    public string? TrailerUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Genre Genre { get; set; }


    public required IEnumerable<ActorDto> Actors { get; set; }

    public required DirectorDto Director { get; set; }

}
