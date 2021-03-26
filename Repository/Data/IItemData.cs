using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface IItemData
    {
        List<AnItem> GetItems();
    }
}
