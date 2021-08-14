using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SeeUsers()
        {
            List<User> usersDb = StaticDb.Users;
            List<UserDetailsViewModel> users = usersDb.Select(x => x.UserToUserDetailsViewModel()).ToList(); 
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AboutUs")]
        public IActionResult About()
        {
            return View();
        }
        [Route("ContactUs")]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ReturnAnotherView()
        {
            return View("NewView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//localhost:344/ContactUs
//localhost:344/AboutUs