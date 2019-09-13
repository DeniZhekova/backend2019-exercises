using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50, "junglebook.jpg", "Jon Favreau");

            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;

            Movie gladiator = new Movie("Gladiator", 49.95, "gladiator.jpg", "Ridley Scott");
            ViewBag.Gladiator = gladiator;

            Movie forrestGump = new Movie("Forrest Gump", 154.50, "forrest-gump.jpg", "Robert Zemeckis");
            ViewBag.ForrestGump = forrestGump;

            return View();
        }
    }
}