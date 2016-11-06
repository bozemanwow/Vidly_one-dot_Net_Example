using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_one.Models;
using Vidly_one.ViewModels;

namespace Vidly_one.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;
        // GET: Random Movies

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Random()
        {
            var viewModel = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.Name == "Lost");
            if (viewModel == null)
                return HttpNotFound();
            var ranmodel = new RandomMovieViewModel()
            {
                Movie = viewModel,
                Customers = new List<Customer>()


            };
        
          

            return View(ranmodel);
        }

        public ActionResult Edit(int moiveId)
        {
            return Content("id="+moiveId.ToString());
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortyBy={1}",pageIndex,sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year.ToString() + "/" + month.ToString());
        }

        public ActionResult DisplayMovies()
        {
            MovieListViewModel movies = new MovieListViewModel();
            movies.Movies = _context.Movies.Include(c => c.GenreType).ToList();

          
            return View(movies);
        }
        [Route("customer/DetailsName/{Id}")]
        public ActionResult MovieDetails(int Id)
        {
            var viewModel = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.Id == Id);
            return View(viewModel);
        }
    }
}