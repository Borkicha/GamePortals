using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePortals.Models;
using GamePortals.Services;
using GamePortals.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace GamePortals.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ApplicationDbContext _context;

        public GamesController(IGameService gameService, ApplicationDbContext context)
        {
            _gameService = gameService;
            _context = context;
        }

        public async Task<IActionResult> Index(int? categoryId, string searchString)
        {
            var gamesQuery = _context.Games.Include(g => g.Genre).AsQueryable();

            if (categoryId.HasValue)
            {
                gamesQuery = gamesQuery.Where(g => g.GenreId == categoryId.Value);
                var category = await _context.Genres.FindAsync(categoryId.Value);
                ViewData["CurrentCategory"] = category?.Name;
                ViewData["CurrentCategoryId"] = categoryId;
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                gamesQuery = gamesQuery.Where(g => g.Title.Contains(searchString));
                ViewData["CurrentFilter"] = searchString;
            }

            var games = await gamesQuery.ToListAsync();
            return View(games);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var game = await _context.Games
                .Include(g => g.Genre)
                .Include(g => g.Reviews)
                    .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (game == null) return NotFound();

            if (game.Reviews != null && game.Reviews.Any())
            {
                ViewBag.AverageRating = game.Reviews.Average(r => r.Rating).ToString("0.0");
            }
            else
            {
                ViewBag.AverageRating = "Няма оценки";
            }

            return View(game);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Name");
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,GenreId,ImageUrl,Price")] Game game)
        {
            if (ModelState.IsValid)
            {
                await _gameService.AddGameAsync(game);
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Name", game.GenreId);
            return View(game);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var game = await _gameService.GetGameByIdAsync(id.Value);
            if (game == null) return NotFound();
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Name", game.GenreId);
            return View(game);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,GenreId,ImageUrl,Price")] Game game)
        {
            if (id != game.Id) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    await _gameService.UpdateGameAsync(game);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var existing = await _gameService.GetGameByIdAsync(game.Id);
                    if (existing == null) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Name", game.GenreId);
            return View(game);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var game = await _gameService.GetGameByIdAsync(id.Value);
            if (game == null) return NotFound();
            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _gameService.DeleteGameAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}