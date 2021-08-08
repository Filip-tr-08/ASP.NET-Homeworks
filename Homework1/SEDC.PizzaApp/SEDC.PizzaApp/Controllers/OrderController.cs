using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> orders = StaticDb.Orders;
            return View(orders);
        }
        [Route("Order/Details/{id?}")]
    public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            else
            {
                Order foundOrder = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
                if (foundOrder == null)
                {
                    return new EmptyResult();
                }
                else
                {
                    return View(foundOrder);
                }
            }
        }
        [Route("Order/JsonData")]
        public IActionResult GetJsonOrder()
        {
            Order order = new Order()
            {
                Id = 1,
                IsDelivery = false,
                PizzasOrdered = StaticDb.Pizzas
            };
            return new JsonResult(order);
        }


        public IActionResult BackToIndexHomeController()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
