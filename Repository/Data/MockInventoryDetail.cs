using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockInventoryDetail : IInventoryDetail
    {
        public IInventoryDetail AddInventoryDetail(int itemNumber, int storeNumber, int stockNumber)
        {
            throw new NotImplementedException();
        }

        public IInventoryDetail ModifyInventoryDetail(int itemNumber, int storeNumber, int newStock)
        {
            throw new NotImplementedException();
        }
    }
}
