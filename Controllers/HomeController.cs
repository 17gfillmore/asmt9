using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;
using Assignment3.Models.ViewModels;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMovieRepository _repository;

        private MovieDbContext context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }


        // when the AddMovie form is retrieved, show the html page with the form
        [HttpGet]                           // attribute 
        public IActionResult AddMovie()     // action
        {
            return View();
        }

        public IActionResult MovieList()
        {
            return View(new MovieListViewModel(context)
            {
                Movies = _repository.Movies
                    //.OrderBy(m => m.Title)

            });

            //return View(model);
        }

        // when the AddMovie form is submitted, pass the new movie object into TempStorage and add it
        [HttpPost]      
        public IActionResult AddMovie(Movie movie)
        {
            TempStorage.AddMovie(movie);
            return View("Confirmation", movie);

            //if (ModelState.IsValid)
            //{
            //    context.Movies.Add(movie);
            //    context.SaveChanges();
            //}

            //return RedirectToAction("Confirmation");
        }

        // ^^ overloaded methods—methods have same name, but different signature/attribute


        // commented out because no action directs to Confirmation and
        // submitting the AddMovie form directs to the confirmation page automatically
        //public IActionResult Confirmation()
        //{
        //    return View();
        //}



        public IActionResult MyPodcasts()
        {
            return View();
        }




        //// update get
        //public IActionResult Update(int movieID)
        //{
        //    MovieID movieID = TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault();
        //    return View(movieID);
        //}

        //// post update according to the movie ID of the parameter and stored movie
        //[HttpPost]
        //public IActionResult Update(Movie movie, int movieID)
        //{
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Category = movie.Category;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Title = movie.Title;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Year = movie.Year;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Director = movie.Director;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Rating = movie.Title;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Edited = movie.Edited;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().LentTo = movie.LentTo;
        //    TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Notes = movie.Notes;

        //    return RedirectToAction("AddMovie");
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
