using BookLibraryApp.Domain.Models;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.MemberViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Controllers
{
    public class MemberController : Controller
    {
        private IMemberServices _memberServices;
        public MemberController(IMemberServices memberServices)
        {
            _memberServices = memberServices;
        }
        public IActionResult Index()
        {
            List<MemberListViewModel>membersDb= _memberServices.GetMembersList();
            return View(membersDb);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try 
            { 
            MemberDetailsViewModel memberDetailsViewModel = _memberServices.GetMember(id.Value);
                return View(memberDetailsViewModel);
            }
            catch(Exception e) 
            {
                return View("ExceptionPage");
            }       
        }
        public IActionResult Create()
        {
            MemberViewModel memberViewModel = new MemberViewModel();
            return View(memberViewModel);
        }
        [HttpPost]
        public IActionResult Create(MemberViewModel memberViewModel)
        {
            try
            {
                _memberServices.CreateMember(memberViewModel);
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
                MemberViewModel memberViewModel = _memberServices.GetMemberForEditing(id.Value);
                return View(memberViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Edit(MemberViewModel memberViewModel)
        {
            try
            {
                _memberServices.EditMember(memberViewModel);
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
                MemberDetailsViewModel memberDetailsViewModel = _memberServices.GetMember(id.Value);
                return View(memberDetailsViewModel);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(MemberDetailsViewModel memberDetailsViewModel)
        {
            try
            {
                _memberServices.DeleteMember(memberDetailsViewModel.Id);
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
