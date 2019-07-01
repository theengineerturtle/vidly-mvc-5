using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;
using System.Net;
//using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _contex;

        public MoviesController()
        {
            _contex = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }

        public ActionResult New()
        {
            var Genres = _contex.Genres.ToList();

            var viewModel = new MovieFormViewModel()
            {
                Genres = Genres,
            };
            ViewBag.FormDescription = "New Movie";

            return View("MovieForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id < 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (movie.Id == 0 )
            {
                movie.DateAdd = DateTime.Now;
                _contex.Movies.Add(movie);
                _contex.SaveChanges();
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                var moviesInDb = _contex.Movies.Single(c => c.Id == movie.Id);

                if (moviesInDb == null)
                    return HttpNotFound();
                //TryUpdateModel(customerInDb); MAYBE WILL BE SECURE PROBLEM
                //Mapper.Map(customer,customerInDb);//Use with Dto in dto you not update all values just which ones you need

                moviesInDb.Name = movie.Name;
                moviesInDb.GenreId = movie.GenreId;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.DateAdd = DateTime.Now;
                moviesInDb.NumberInStock = movie.NumberInStock;
            }
            _contex.SaveChanges();
            return RedirectToAction("Index", "Movies");
           
        }

        public ActionResult Edit(int id)
        {
            var movie = _contex.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var genreTypes = _contex.Genres.ToList();

            var viewmodel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = genreTypes,
            };
            ViewBag.FormDescription = "Edit Movie";

            return View("MovieForm", viewmodel);
        }

       
        // GET: Movies
        //public ActionResult Random()
        //{
        //    Movie movie = new Movie()
        //    {
        //        Name = "Shrek!"

        //    };

        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name="Customer Name : Gökhan"},
        //        new Customer {Name="Customer Name : Barış"},
        //    };

        //    RandomMovieViewModels viewModels = new RandomMovieViewModels()
        //    {
        //        Movie = movie,
        //        Customers = customers,
        //    };

        //    //ViewData["Movie"] = movie;
        //    //ViewBag.RandomMovie = movie;
        //    return View(viewModels);
        //}

        public ActionResult Index()
        {
            var movies = _contex.Movies.Include(c=>c.Genre).ToList();
          
            return View(movies);
        }


        public ActionResult Details(int id)
        {
            var movie = _contex.Movies.Include(c=>c.Genre).SingleOrDefault(m => m.Id == id);

            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year:range(2000,2060)}/{month:range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year + "/" + month);
        //}
        
    }
}