using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Index page";
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaDetailsViewModel> pizzaViewModels = pizzas.Select(x => x.PizzaToPizzaDetailsViewModel()).ToList();
            return View(pizzaViewModels); 
        }

        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Details";
            if(id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                return new EmptyResult();
            }
            PizzaDetailsViewModel pizzaViewModel = pizza.PizzaToPizzaDetailsViewModel();
            ViewBag.PizzaViewModel = pizzaViewModel;
            return View(pizzaViewModel);
        }
        [Route("SeePizzas")] 
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
