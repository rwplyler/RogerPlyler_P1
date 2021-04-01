using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data 
{
    public class AcustomerData : ICustomerData
    {

        Project1Context context = new Project1Context();

        public Acustomer AddCustomer(Acustomer customer)
        {
            
            return customer;
        }

        public void DeleteCustomer(Acustomer customer)
        {
            throw new NotImplementedException();
        }

        public Acustomer DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Acustomer EditCustomer(Acustomer customer)
        {
            throw new NotImplementedException();
        }

        public Acustomer GetCustomer(int id)
        {
            Acustomer customer = context.Acustomers.SingleOrDefault(c => c.Id == id);
            return customer;
        }

        public Acustomer GetCustomer(string fname, string lname)
        {
            Acustomer customer = context.Acustomers.SingleOrDefault(c => c.Fname == fname && c.Lname == lname);
            return customer;
        }

        public Acustomer GetCustomer(Acustomer customer)
        {
            return context.Acustomers.SingleOrDefault(c => c.Fname == customer.Fname && c.Lname == customer.Lname);
        }

        public List<Acustomer> GetCustomers()
        {
            return context.Acustomers.ToList();
        }
    }
}
