﻿using SEDC.PizzaApp.Domain.Models;
using System.Collections.Generic;

namespace SEDC.PizzaApp.DataAccess.Interfaces
{
    public interface IPizzaRepository : IRepository<Pizza>
    {
        //we assume that only one pizza is on promotion
        Pizza GetPizzaOnPromotion();
        List<Order> ConnectedOrders(int id);
    }
}
