using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class MockCustomerData : ICustomerData
    {
        List<Acustomer> customers = new List<Acustomer>() {
            new Acustomer{
                Id = 1,
                Fname = "Roger",
                Lname = "Plyler"
            },
            new Acustomer
            {
                Id = 2,
                Fname = "Ferb",
                Lname = "Fletcher"
            }
        };


        public Acustomer AddCustomer(Acustomer customer)
        {
            customers.Add(customer);
            return customer;
        }

        public void DeleteCustomer(Acustomer customer)
        {
            var cust = customers.SingleOrDefault(c => c.Id == customer.Id);
            customers.Remove(cust);

        }

        public Acustomer EditCustomer(Acustomer customer)
        {
            customers.SingleOrDefault(c => c.Id == customer.Id).Fname = customer.Fname;
            customers.SingleOrDefault(c => c.Id == customer.Id).Lname = customer.Lname;
            return customers.SingleOrDefault(c => c.Id == customer.Id);
        }

        public Acustomer GetCustomer(int id)
        {
            return customers.SingleOrDefault(x => x.Id == id);
        }

        public List<Acustomer> GetCustomers()
        {
            return customers;
        }

        public Acustomer GetCustomer(Acustomer customer)
        {
            return customers.Find(c => c.Fname == customer.Fname && c.Lname == customer.Lname);
        }

        public Acustomer DeleteCustomer(int id)
        {
            var cust = customers.Find(c => c.Id == id);
            customers.Remove(cust);
            return cust;
        }
    }
}
