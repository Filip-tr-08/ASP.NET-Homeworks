using BookLibraryApp.Services.Implementations;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.ReservationViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class ReservationController : Controller
    {
        private IReservationServices _reservationServices;
        private IMemberServices _memberServices;
        private IBookServices _bookServices;
        public ReservationController(IReservationServices reservationServices, IMemberServices memberServices, IBookServices bookServices)
        {
            _reservationServices = reservationServices;
            _memberServices = memberServices;
            _bookServices = bookServices;
        }
        public IActionResult Index()
        {
            List<ReservationListViewModel> reservationListViewModels = _reservationServices.GetAllReservations();
            return View(reservationListViewModels);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                ReservationDetailsViewModel reservationDetailsViewModel = _reservationServices.GetReservationById(id.Value); // value bidejki parametarot id e nullable value a metodot getReservationbyId mora da dobie integer Id
                return View(reservationDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
        public IActionResult Create()
        {
            ReservationViewModel reservationViewModel = new ReservationViewModel();
         
            ViewBag.Members = _memberServices.GetMembersForDropDown();
            return View(reservationViewModel);
        }
        [HttpPost]
        public IActionResult Create(ReservationViewModel reservationViewModel)
        {
            try
            {
                _reservationServices.CreateReservation(reservationViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                ReservationViewModel reservationViewModel = _reservationServices.GetReservationForEditing(id.Value);
                ViewBag.Members = _memberServices.GetMembersForDropDown();
                return View(reservationViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Edit(ReservationViewModel reservationViewModel)
        {
            try
            {
                _reservationServices.EditReservation(reservationViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                ReservationDetailsViewModel reservationDetailsViewModel = _reservationServices.GetReservationById(id.Value);
                return View(reservationDetailsViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(ReservationDetailsViewModel reservationDetailsViewModel)
        {
            try
            {
                _reservationServices.DeleteReservation(reservationDetailsViewModel.Id);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");

            }
        }
        public IActionResult AddBook(int id)
        {
            BookReservationViewModel bookReservationViewModel = new BookReservationViewModel();
            bookReservationViewModel.ReservationId = id;
            ViewBag.Books = _bookServices.GetBooksForDropDown();
            return View(bookReservationViewModel);
        }
        [HttpPost]
        public IActionResult AddBook(BookReservationViewModel bookReservationViewModel)
        {
            try
            {
                _reservationServices.AddBookToReservation(bookReservationViewModel);
                return RedirectToAction("Details", new { id = bookReservationViewModel.ReservationId });
            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
    }
}
