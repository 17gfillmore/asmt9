using System;
using System.Collections.Generic;

namespace Assignment3.Models.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }

        public MovieListViewModel(MovieDbContext context)
        {
            Movies = context.Movies;
        }

    }
}
