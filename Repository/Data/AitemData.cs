using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class AitemData : IItemData
    {
        Project1Context context = new Project1Context();

        public AnItem GetItem(int id)
        {
            return context.AnItems.SingleOrDefault(i => i.Id == id);
        }

        public List<AnItem> GetItems()
        {
            return context.AnItems.ToList();
        }
    }
}
