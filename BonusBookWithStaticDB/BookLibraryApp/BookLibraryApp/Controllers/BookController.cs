using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class BookController : Controller
    {
        private IBookServices _bookServices;
        private IAuthorServices _authorServices;
        public BookController(IBookServices bookServices, IAuthorServices authorServices)
        {
            _bookServices = bookServices;
            _authorServices = authorServices;
        }
        public IActionResult Index()
        {
            List<BookListViewModel> bookListViewModels = _bookServices.GetBooksList();
            return View(bookListViewModels);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                BookDetailsViewModel bookDetailsViewModel = _bookServices.GetBook(id.Value);
                return View(bookDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
        public IActionResult Create()
        {
            BookViewModel bookViewModel = new BookViewModel();
            ViewBag.Authors = _authorServices.GetAuthorsForDropDown();
            return View(bookViewModel);
        }
        [HttpPost]
        public IActionResult Create(BookViewModel bookViewModel)
        {
            try
            {
                _bookServices.CreateBook(bookViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("Index");
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
                BookViewModel bookViewModel = _bookServices.GetBookForEditing(id.Value);
                ViewBag.Authors = _authorServices.GetAuthorsForDropDown();
                return View(bookViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Edit(BookViewModel bookViewModel)
        {
            try
            {
                _bookServices.EditBook(bookViewModel);
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
                BookDetailsViewModel bookDetailsViewModel = _bookServices.GetBook(id.Value);
                return View(bookDetailsViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(BookDetailsViewModel bookDetailsViewModel)
        {
            try
            {
                _bookServices.DeleteBook(bookDetailsViewModel.Id);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");

            }
        }
    }
}
