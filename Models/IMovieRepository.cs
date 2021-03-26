using System;
using System.Linq;

namespace Assignment3.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
