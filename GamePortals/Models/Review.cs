using System.ComponentModel.DataAnnotations;

namespace GamePortals.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        [Range(0, 5)]
        public int Rating { get; set; }

        public int GameId { get; set; }
        public Game? Game { get; set; }

        public string? UserId { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser? User { get; set; }
    }
}