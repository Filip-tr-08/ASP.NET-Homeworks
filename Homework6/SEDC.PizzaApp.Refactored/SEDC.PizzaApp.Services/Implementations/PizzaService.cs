using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.OrderViewModels;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository) //Dependency Injection
        {
            _pizzaRepository = pizzaRepository;
        }
        public List<PizzaDDViewModel> GetPizzasForDropdown()
        {
            //get from db
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            //map to view models
            return pizzasDb.Select(x => x.ToPizzaDDViewModel()).ToList();
        }

        public string GetPizzaOnPromotion()
        {
            return _pizzaRepository.GetPizzaOnPromotion().Name;
        }
        public void CreatePizza(PizzaViewModel pizzaViewModel)
        {
            List<Pizza> pizzasDb = _pizzaRepository.GetAll().Where(x => x.IsOnPromotion == true).ToList();
            if (pizzasDb.Count > 1)
            {
                throw new Exception("There can be only one pizza on promotion");
            }
            Pizza pizza = pizzaViewModel.ToPizza();
            int newPizzaId = _pizzaRepository.Insert(pizza);
            if (newPizzaId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }

        public List<PizzaListViewModel> GetAllPizzas()
        {
            List<Pizza> dbPizzas = _pizzaRepository.GetAll();
            return dbPizzas.Select(x => x.PizzaToPizzaListViewModel()).ToList();
        }

        public PizzaDetailsViewModel GetPizzaDetails(int id)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(id);
            if (pizzaDb == null)
            {
                throw new Exception($"The pizza with id {id} is not found");
            }
            return pizzaDb.pizzaDetailsViewModel();
        }
        public List<OrderListViewModel> GetOrderListViewModels(int id)
        {
            List<Order> ordersDb = _pizzaRepository.ConnectedOrders(id);
            return ordersDb.Select(x => x.OrderToOrderListViewModel()).ToList();
        }
    }
}
