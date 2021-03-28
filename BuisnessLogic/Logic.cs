using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessLogic
{
    public class Logic
    {
        Project1Context context;
        public Logic()
        {
            context = new Project1Context();
        }

        public Aorder NewOrder(int custID, int storeID, decimal tot)
        {
            var order = new Aorder()
            {
                CustomerId = custID,
                StoreId = storeID,
                Total = tot,
                OrderTime = DateTime.Now,
                OrderId = context.Aorders.Max(o => o.OrderId) + 1
            };
            context.Aorders.Add(order);
            context.SaveChanges();
            return order;
        }

        
    }
}
