using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var Movies = GetMovies();
            return View(Movies);
        }

        public ActionResult Details(int Id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.ID == Id);
            return View(movie);
        }

        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
        {
            new Movies { ID = 1, Name = "Iron Man (2008)"},
            new Movies { ID = 2, Name = "The Incredible Hulk (2008)" },
            new Movies { ID = 3, Name = "Iron Man 2 (2010))" },
            new Movies { ID = 4, Name = "Thor (2011)" },
            new Movies { ID = 5, Name = "Captain America: The First Avenger (2011)" },
            new Movies { ID = 6, Name = "Marvel's The Avengers (2012)"},
            new Movies { ID = 7, Name = "Iron Man 3 (2013))"},
            new Movies { ID = 8, Name = "Thor: The Dark World (2013)"},
            new Movies { ID = 9, Name = "Captain America: The Winter Soldier (2014)"},
            new Movies { ID = 10, Name = "Guardians of the Galaxy (2014)"},
            new Movies { ID = 11, Name = "Avengers: Age of Ultron (2015)"},
            new Movies { ID = 12, Name = "Ant-Man (2015)"},
            new Movies { ID = 13, Name = "Captain America: Civil War (2016))"},
            new Movies { ID = 14, Name = "Doctor Strange (2016))"},
            new Movies { ID = 15, Name = "Guardians of the Galaxy Vol. 2 (2017"},
            new Movies { ID = 16, Name = "Spider-Man: Homecoming (2017)"},
            new Movies { ID = 17, Name = "Thor: Ragnarok (2017)"},
            new Movies { ID = 18, Name = "Black Panther (2018)"},
            new Movies { ID = 19, Name = "Avengers: Infinity War (2018)"},
            new Movies { ID = 20, Name = "Ant-Man and the Wasp (2018)"}
        };
        }

    }

    
}