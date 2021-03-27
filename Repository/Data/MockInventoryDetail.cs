using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockInventoryDetail : IInventoryDetail
    {
        List<InventoryDetail> stockData = new List<InventoryDetail>() { 
            new InventoryDetail(){
                StoreId = 1,
                ItemId = 1,
                Amount = 2
            },
            new InventoryDetail(){
                StoreId = 2,
                ItemId = 1,
                Amount = 2
            },
            new InventoryDetail(){
                StoreId = 1,
                ItemId = 2,
                Amount = 2
            }


        };


        public InventoryDetail AddInventoryDetail(int itemNumber, int storeNumber, int stockNumber)
        {
            throw new NotImplementedException();
        }

        public List<InventoryDetail> GetInventoryDetails()
        {
            return stockData;
        }

        public InventoryDetail ModifyInventoryDetail(int itemNumber, int storeNumber, int newStock)
        {
            throw new NotImplementedException();
        }

        
    }
}
