using System;
using System.Collections.Generic;


namespace Assignment3.Models
{
    public static class TempStorage
    {
        // this class stores the Movie data with a list holding each created movie object from the form submission

        private static List<Movie> movies = new List<Movie>();

        // returns the full list of movies
        public static IEnumerable<Movie> Movies => movies;

        // when called, adds the movie object passed in to the list
        public static void AddMovie(Movie movie)
        {
            if (movie.Title != "Independence Day")
            {
                movies.Add(movie);
            }
        }

    }
}
