using GamePortals.Data;
using GamePortals.Models;
using Microsoft.EntityFrameworkCore;

namespace GamePortals.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game>> GetAllGamesAsync()
            => await _context.Games.Include(g => g.Genre).ToListAsync();

        public async Task<Game> GetGameByIdAsync(int id)
            => await _context.Games.Include(g => g.Genre)
                                   .Include(g => g.Reviews)
                                   .FirstOrDefaultAsync(m => m.Id == id);

        public async Task AddGameAsync(Game game)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGameAsync(Game game)
        {
            _context.Update(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGameAsync(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
            }
        }
    }
}