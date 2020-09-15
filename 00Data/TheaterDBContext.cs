using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterMovieAdmin._00Data
{
    public class TheaterDBContext : DbContext


    {

        public TheaterDBContext(DbContextOptions<TheaterDBContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
