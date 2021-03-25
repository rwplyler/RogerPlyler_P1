using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface ICustomerData
    {
        List<Acustomer> GetCustomers();
        Acustomer GetCustomer(int id);
        Acustomer AddCustomer(Acustomer customer);
        Acustomer editCustomer(Acustomer customer);
        void DeleteCustomer(Acustomer customer);


    }
}
