using System.ComponentModel.DataAnnotations; 

public class Review
{
    public int Id { get; set; }

    public string Content { get; set; }

    [Range(0, 10)] 
    public int Rating { get; set; }

    public int GameId { get; set; }
    public Game? Game { get; set; }

    public string? UserId { get; set; }
    public Microsoft.AspNetCore.Identity.IdentityUser? User { get; set; }
}