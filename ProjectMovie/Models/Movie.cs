using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ProjectMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        // Validation will apply to all views connect to this model
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
<<<<<<< HEAD

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
=======
>>>>>>> 6e76f8f9d0c7faf21f4b9a2a9c4e1aeeaf8dc65d
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}