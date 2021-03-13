using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebUI.DataAccess;
using MVCWebUI.Models;
using MVCWebUI.Models.Entity;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(int ? id)
        {
            var movies = MovieRepository.GetList();
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
