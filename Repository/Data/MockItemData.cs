using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockItemData : IItemData
    {
        List<AnItem> items = new List<AnItem>(){
            new AnItem(){
            Id = 1,
            ItemName = "Playstation",
            Price = 500.00m
            },
            new AnItem(){
            Id = 2,
            ItemName = "Playstation",
            Price = 500.00m
            }
            };

        public List<AnItem> GetItems()
        {
            return items;
        }
    }
}
