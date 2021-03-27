using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    /// <summary>
    /// Interface for Customer data
    /// </summary>
    public interface ICustomerData
    {
        

        List<Acustomer> GetCustomers();

        Acustomer GetCustomer(int id);

        Acustomer GetCustomer(string fname, string lname);

        Acustomer AddCustomer(Acustomer customer);

        void DeleteCustomer(Acustomer customer);

        Acustomer DeleteCustomer(int id);

        Acustomer EditCustomer(Acustomer customer);

        Acustomer GetCustomer(Acustomer customer);
    }
}
