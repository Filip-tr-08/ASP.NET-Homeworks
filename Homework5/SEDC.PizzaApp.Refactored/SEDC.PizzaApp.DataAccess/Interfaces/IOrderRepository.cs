using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Interfaces
{
    public interface IOrderRepository:IRepository<Order>
    {
        //void DeletePizzaOrder(int id, int pizzaOrderId);
    }
}
