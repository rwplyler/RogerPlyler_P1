using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface IOrderData
    {
        List<Aorder> GetOrders();

        List<Aorder> GetOrdersByStore(int StoreID);

        List<Aorder> GetOrdersByCustomer(int customerID);

        Aorder AddOrder(Aorder newOrder);

    }
}
