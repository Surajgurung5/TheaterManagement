using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterMovieAdmin._00Data
{
    public class Movie
    {
        public int Movieid { get; set; }
        [StringLength(50)]
        [Required]

        public string Name { get; set; }
        [Required]

        public DateTime ReleaseDate { get; set; }
        [Required]

        public string Director { get; set; }
        [Required]

        public string EmailAddress { get; set; }
        
        [Required]

        public string Language { get; set; }
        
    }

    public class Category
    {
        public string CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Code { get; set; }

    }
}
