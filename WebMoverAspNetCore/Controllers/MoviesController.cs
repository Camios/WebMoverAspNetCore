using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMoverAspNetCore.Models;

namespace WebMoverAspNetCore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly Movies _movies;

        public MoviesController(Movies movies)
        {
            _movies = movies;
        }

        // GET: Movies
        public ActionResult Index()
        {
            var model = GetMovieListViewModel();
            return View(model);
        }

        private MovieListViewModel GetMovieListViewModel()
        {
            var model = new MovieListViewModel
            {
                Movies = _movies.GetAll().OrderBy(m => m.Title)
            };
            return model;
        }

        // Get: Movies/Archive/5
        [HttpGet]
        public ActionResult Archive(int id)
        {
            // TODO find the movie with Id == id
            var movie = _movies.Get(id);
            if (movie != null)
            {
                // TODO attempt to move the movie
                // TODO attempt to make radarr update the new file path
                // TODO attempt to make radarr stop monitoring the movie
                TempData["Notification"] = $"Successfully archived {movie.Title}";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["Notification"] = $"Failed to locate movie with id {id}";
                return View(nameof(Index), GetMovieListViewModel());
            }
        }

        //// GET: Movies/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Movies/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Movies/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Movies/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Movies/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Movies/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Movies/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}