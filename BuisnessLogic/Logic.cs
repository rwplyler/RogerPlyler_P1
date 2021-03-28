using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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

        public decimal NewOrderDetail(int orderNum, int itemNum, int amount)
        {
            Aorder getorder = context.Aorders.FirstOrDefault(o=> o.OrderId == orderNum);
            List<InventoryDetail> inventory = context.InventoryDetails.ToList();
            inventory.Find(i => getorder.StoreId == i.StoreId && itemNum == i.ItemId).Amount -= amount;
            context.InventoryDetails.Update(inventory.Find(i => getorder.StoreId == i.StoreId && itemNum == i.ItemId));
            context.SaveChanges();
           
                AorderDetail newDetail = new AorderDetail()
            {
               Id = ((context.AorderDetails.Any(o => o.Id == 1)) ? context.AorderDetails.Max(o => o.Id) + 1 : 1),
                OrderId = orderNum,
                ItemId = itemNum,
                Total = Convert.ToDecimal(amount)

            };
            
            context.AorderDetails.Add(newDetail);
            context.SaveChanges();
            

            return 0.0m;
        }

        
    }
}
