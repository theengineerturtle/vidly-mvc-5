﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
//using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
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
            IEnumerable<Movie> movies = new List<Movie>()
            {
                new Movie{Id=1,Name="Shrek!"},
                new Movie{Id=2,Name="Wall-e"}
            };

            return View(movies);
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