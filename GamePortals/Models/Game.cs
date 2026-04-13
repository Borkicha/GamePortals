public class Game
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }
    public List<Review> Reviews { get; set; } = new();
    public List<GameUser> GameUsers { get; set; } = new(); // мени-мени
}