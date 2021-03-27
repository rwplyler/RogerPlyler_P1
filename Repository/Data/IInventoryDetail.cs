using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface IInventoryDetail
    {
        InventoryDetail ModifyInventoryDetail(int itemNumber, int storeNumber, int newStock);

        InventoryDetail AddInventoryDetail(int itemNumber, int storeNumber, int stockNumber);

        List<InventoryDetail> GetInventoryDetails();
    }
}
