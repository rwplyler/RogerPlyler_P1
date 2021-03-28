using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class AstoreData : IStoreData
    {
        Project1Context context = new Project1Context();
        public List<Astore> GetStores()
        {
            return context.Astores.ToList();
        }
    }
}
