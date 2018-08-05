using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie{Name = "Shrek!"},
                new Movie{Name = "Green Mile"}
            };
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Doe" },
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
        }
        public ActionResult Movies()
        {
            var movie = new List<Movie>
            {
                new Movie{Name = "Shrek!"},
                new Movie{Name = "Green Mile"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
            };

            return View(viewModel);
        }
        //        public ActionResult Edit(int id)
        //        {
        //            return Content(("id=" + id));
        //        }
        //        // movies
        //        public ActionResult Index(int? pageIndex, string sortBy)
        //        {
        //            if (!pageIndex.HasValue)
        //            {
        //                pageIndex = 1;
        //            }
        //
        //            if (String.IsNullOrWhiteSpace(sortBy))
        //            {
        //                sortBy = "Name";
        //            }
        //
        //            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //        }
        //        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //        public ActionResult ByReleaseYear(int year, int month)
        //        {
        //            return Content(year + "/" + month);
        //        }
    }
}