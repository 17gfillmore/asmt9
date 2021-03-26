using System;
using System.Linq;

namespace Assignment3.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext context;

        // constructor
        public EFMovieRepository(MovieDbContext ctx)
        {
            context = ctx;
        }

        // dbSet of Movies in MovieDbContext
        public IQueryable<Movie> Movies => context.Movies;
    }
}
