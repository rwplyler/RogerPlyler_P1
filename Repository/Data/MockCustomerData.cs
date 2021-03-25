using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class MockCustomerData : ICustomerData
    {
        List<Acustomer> mockCustomers = new List<Acustomer>()
        {
            new Acustomer(){
                Id = 1,
                CustomerName = "Roger Plyler",
                LocationId = 1
            },
            new Acustomer(){
                Id = 2,
                CustomerName = "John Cena",
                LocationId = 2
            }

        };
        public Acustomer AddCustomer(Acustomer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Acustomer customer)
        {
            throw new NotImplementedException();
        }

        public Acustomer editCustomer(Acustomer customer)
        {
            throw new NotImplementedException();
        }

        public List<Acustomer> GetCustomers()
        {
            return mockCustomers;
        }

        public Acustomer GetCustomer(int id)
        {
            return mockCustomers.SingleOrDefault(x => x.Id == id);
        }
    }
}
