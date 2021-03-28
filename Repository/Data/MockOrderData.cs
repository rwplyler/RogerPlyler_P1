using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockOrderData : IOrderData
    {
        List<Aorder> orders = new List<Aorder>() {
            new Aorder{
                OrderId = 1,
                CustomerId = 1,
                StoreId = 1,
                OrderTime = DateTime.Now,
                Total = 500.00m
            },
            new Aorder{
                OrderId = 2,
                CustomerId = 2,
                StoreId = 2,
                OrderTime = DateTime.Now,
                Total = 400.00m
            },
            new Aorder{
                OrderId = 3,
                CustomerId = 2,
                StoreId = 1,
                OrderTime = DateTime.Now,
                Total = 400.00m
            }

        };


        public Aorder AddOrder(Aorder newOrder)
        {
            orders.Add(newOrder);
            return newOrder;
        }

        public List<Aorder> GetOrdersByCustomer(int customerID)
        {
            return orders.FindAll(o => o.CustomerId == customerID);
        }

        public List<Aorder> GetOrders()
        {
            return orders;
        }

        public List<Aorder> GetOrdersByStore(int StoreID)
        {
            return orders.FindAll(o => o.StoreId == StoreID);
        }
    }
}
