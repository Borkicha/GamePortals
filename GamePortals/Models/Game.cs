using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamePortals.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заглавието е задължително")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Display(Name = "Линк към снимка")]
        public string? ImageUrl { get; set; }

        [Range(0, 1000, ErrorMessage = "Цената трябва да е между 0 и 1000 евро.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }

        public List<Review> Reviews { get; set; } = new();

        public List<GameUser> GameUsers { get; set; } = new();
    }
}