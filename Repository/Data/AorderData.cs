using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class AorderData : IOrderData
    {
        Project1Context context = new Project1Context();
        public Aorder AddOrder(Aorder newOrder)
        {
            context.Aorders.Add(newOrder);
            return newOrder;
        }

        public List<Aorder> GetOrders()
        {
            return context.Aorders.ToList();
        }

        public List<Aorder> GetOrdersByCustomer(int customerID)
        {
            return context.Aorders.Where(o => o.CustomerId == customerID).ToList();
        }

        public List<Aorder> GetOrdersByStore(int StoreID)
        {
            return context.Aorders.Where(o => o.StoreId == StoreID).ToList();
        }
    }
}
