using Core.Models;

namespace Core.Dtos;

public class ActorDto //: ObjectType<Actor> 

{

    public Guid Id { get; set; }

    public required string Name { get; set; }

    public string? Bio { get; set; }

    public string? ImageUrl { get; set; }

    //public List<Movie> Movies { get; set; } = new List<Movie>();

}
