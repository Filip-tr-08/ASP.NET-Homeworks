using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.AuthorViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorServices _authorServices;
        public AuthorController(IAuthorServices authorServices)
        {
            _authorServices = authorServices;
        }
        public IActionResult Index()
        {
            List<AuthorListViewModel> authorListViewModels = _authorServices.GetAuthorsList();
            return View(authorListViewModels);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                AuthorDetailsViewModel authorDetailsViewModel = _authorServices.GetAuthor(id.Value);
                return View(authorDetailsViewModel);
            }
            catch(Exception e)
            {
                return View("ExceptionPage");
            }
        }
        public IActionResult Create()
        {
            AuthorViewModel authorViewModel = new AuthorViewModel();
            return View(authorViewModel);
        }
        [HttpPost]
        public IActionResult Create(AuthorViewModel authorViewModel)
        {
            try
            {
                _authorServices.CreateAuthor(authorViewModel);
                return RedirectToAction("Index");
            }
            catch(Exception e)
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
                AuthorViewModel authorViewModel = _authorServices.GetAuthorForEditing(id.Value);
                return View(authorViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Edit(AuthorViewModel authorViewModel)
        {
            try
            {
                _authorServices.EditAuthor(authorViewModel);
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
                AuthorDetailsViewModel authorDetailsViewModel = _authorServices.GetAuthor(id.Value);
                return View(authorDetailsViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(AuthorDetailsViewModel authorDetailsViewModel)
        {
            try
            {
                _authorServices.DeleteAuthor(authorDetailsViewModel.Id);
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
