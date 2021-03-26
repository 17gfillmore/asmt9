//using System;
//using System.Linq;
//using Assignment3.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Assignment3.Controllers
//{
//    public class MovieController : HomeController
//    {
//        // update getdot
//        public IActionResult Update(int movieID)
//        {
//            MovieID movieID = TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault();
//            return View(movieID);
//        }

//        // post update according to the movie ID of the parameter and stored movie
//        [HttpPost]
//        public IActionResult Update(Movie movie, int movieID)
//        {
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Category = movie.Category;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Title = movie.Title;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Year = movie.Year;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Director = movie.Director;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Rating = movie.Title;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Edited = movie.Edited;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().LentTo = movie.LentTo;
//            TempStorage.Movies.Where(m => m.MovieID == movieID).FirstOrDefault().Notes = movie.Notes;

//            return RedirectToAction("AddMovie");
//        }
//    }
//}
