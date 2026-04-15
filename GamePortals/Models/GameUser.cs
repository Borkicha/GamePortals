namespace GamePortals.Models
{
    public class GameUser
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public Game? Game { get; set; }

        public string? UserId { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityUser? User { get; set; }
    }
}