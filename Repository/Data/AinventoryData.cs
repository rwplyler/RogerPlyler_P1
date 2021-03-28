using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class AinventoryData : IInventoryDetail
    {
        Project1Context context = new Project1Context();

        public InventoryDetail AddInventoryDetail(int itemNumber, int storeNumber, int stockNumber)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDetail> GetInventoryDetails()
        {
            return context.InventoryDetails.ToList();
        }

        public InventoryDetail GetInventoryItem(int itemid, int storeid)
        {
            return context.InventoryDetails.SingleOrDefault(i => i.ItemId == itemid && i.StoreId == storeid);
        }

        public List<InventoryDetail> GetInventoryStore(int id)
        {
            return context.InventoryDetails.Where(i => i.StoreId == id).ToList();
        }

        public InventoryDetail ModifyInventoryDetail(int itemNumber, int storeNumber, int newStock)
        {
            throw new NotImplementedException();
        }
    }
}
