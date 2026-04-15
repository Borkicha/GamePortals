using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePortals.Models;
using GamePortals.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GamePortals.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace GamePortals.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly ApplicationDbContext _context;

        public ReviewsController(IReviewService reviewService, ApplicationDbContext context)
        {
            _reviewService = reviewService;
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index(string sortOrder)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IQueryable<Review> reviewsQuery = _context.Reviews
                .Include(r => r.Game)
                .Include(r => r.User);

            if (User.IsInRole("Admin"))
            {
                ViewData["HeaderTitle"] = "Админ Панел - Всички Ревюта";
                reviewsQuery = sortOrder == "game"
                    ? reviewsQuery.OrderBy(r => r.Game.Title)
                    : reviewsQuery.OrderByDescending(r => r.Id);
            }
            else
            {
                ViewData["HeaderTitle"] = "Моите Ревюта";
                reviewsQuery = reviewsQuery.Where(r => r.UserId == userId);
                reviewsQuery = sortOrder == "rating"
                    ? reviewsQuery.OrderByDescending(r => r.Rating)
                    : reviewsQuery.OrderByDescending(r => r.Id);
            }

            ViewData["CurrentSort"] = sortOrder;
            var reviews = await reviewsQuery.ToListAsync();
            return View(reviews);
        }

        [Authorize]
        public IActionResult Create(int? id)
        {
            if (id == null) return NotFound();
            var game = _context.Games.FirstOrDefault(g => g.Id == id);
            if (game == null) return NotFound();

            ViewBag.GameTitle = game.Title;
            ViewBag.GameId = id;
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Content,Rating,GameId")] Review review)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            review.UserId = userId;

            var alreadyExists = await _context.Reviews
                .AnyAsync(r => r.GameId == review.GameId && r.UserId == userId);

            if (alreadyExists)
            {
                ModelState.AddModelError("", "Вече сте написали ревю за тази игра.");
            }

            if (ModelState.IsValid)
            {
                await _reviewService.AddReviewAsync(review);
                return RedirectToAction("Details", "Games", new { id = review.GameId });
            }

            var game = await _context.Games.FindAsync(review.GameId);
            ViewBag.GameTitle = game?.Title;
            ViewBag.GameId = review.GameId;
            return View(review);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var review = await _context.Reviews.Include(r => r.Game).FirstOrDefaultAsync(r => r.Id == id);
            if (review == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && review.UserId != currentUserId) return Forbid();

            ViewBag.GameTitle = review.Game?.Title;
            return View(review);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,Rating,GameId,UserId")] Review review)
        {
            if (id != review.Id) return NotFound();
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && review.UserId != currentUserId) return Forbid();

            if (ModelState.IsValid)
            {
                try { await _reviewService.UpdateReviewAsync(review); }
                catch (DbUpdateConcurrencyException) { if (await _reviewService.GetReviewByIdAsync(review.Id) == null) return NotFound(); else throw; }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var review = await _context.Reviews.Include(r => r.Game).Include(r => r.User).FirstOrDefaultAsync(r => r.Id == id);
            if (review == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && review.UserId != currentUserId) return Forbid();
            return View(review);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _reviewService.GetReviewByIdAsync(id);
            if (review == null) return NotFound();
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (User.IsInRole("Admin") || review.UserId == currentUserId)
            {
                await _reviewService.DeleteReviewAsync(id);
                return RedirectToAction(nameof(Index));
            }
            return Forbid();
        }
    }
}