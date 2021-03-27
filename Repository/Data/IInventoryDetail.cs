using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface IInventoryDetail
    {
        IInventoryDetail ModifyInventoryDetail(int itemNumber, int storeNumber, int newStock);

        IInventoryDetail AddInventoryDetail(int itemNumber, int storeNumber, int stockNumber);

    }
}
