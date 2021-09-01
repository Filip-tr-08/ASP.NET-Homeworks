using BookLibraryApp.Models;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.HomeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookServices _bookServices;
        private IReservationServices _reservationServices;

        public HomeController(ILogger<HomeController> logger, IBookServices bookServices, IReservationServices reservationServices)
        {
            _logger = logger;
            _bookServices = bookServices;
            _reservationServices = reservationServices;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel();
            homeIndexViewModel.BooksOnPromotion = _bookServices.GetBooksOnPromotion();
            homeIndexViewModel.ReservationCount = _reservationServices.GetAllReservations().Count;
            return View(homeIndexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
