using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockStoreData : IStoreData
    {
        List<Astore> stores = new List<Astore>()
        {
            new Astore{
                Id = 1,
                StoreName = "JackBox"
            },
            new Astore
            {
                Id = 2,
                StoreName = "Retro Reboot"
            }
            
        };

        public List<Astore> GetStores()
        {
            return stores;
        }
    }
}
