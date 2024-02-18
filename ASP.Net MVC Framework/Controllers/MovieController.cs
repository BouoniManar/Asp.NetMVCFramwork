using ASP.Net_MVC_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_MVC_Framework.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            Movie movie = new Movie() { Name = "movie 1" };
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
            };
            return View(movies);

           
        }

        public ActionResult Edit(int id)
        {
            return Content("Id" + id);
        }


        [Route("movies/released/{year}/{month}")]
        public ActionResult byRelease(int year, int month)
        {
            return Content(year + "/" + month);
        }


        public ActionResult Auteurs(int id)
        {
            
            Movie movie = GetMovieByID(id);


            return View(movie.Auteurs);
        }

       
            private Movie GetMovieByID(int id)
            {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { id = 1, Name = "Movie 1" },
                new Movie { id = 2, Name = "Movie 2" }

            };

                return movies.FirstOrDefault(m => m.id == id);
            }
        }
    }
    