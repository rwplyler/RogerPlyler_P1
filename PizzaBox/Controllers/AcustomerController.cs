using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuisnessLogic;

namespace PizzaBox.Controllers
{
    [ApiController]
    public class AcustomerController : Controller
    {
        private ICustomerData customerData;
        public AcustomerController(ICustomerData _customerData)
        {
            customerData = _customerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(customerData.GetCustomers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCustomer(int ID)
        {
            var customer = customerData.GetCustomer(ID);
            if(customer != null)
            {
                return Ok(customer);
            }
            return NotFound("Customer Not Found");
        }

        [HttpGet]
        [Route("api/[controller]/{fname}/{lname}")]
        public IActionResult GetCustomer(string fname,string lname)
        {
            var customer = customerData.GetCustomer(fname,lname);
            if (customer != null)
            {
                return Ok(customer);
            }
            Acustomer empty = new Acustomer() { Id = 0 };

            return Ok(empty);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetCustomer(Acustomer customer)
        {
            Logic buis = new Logic();
            //return Ok(customerData.GetCustomers());
            var checkCust = customerData.GetCustomer(customer);
            if(checkCust == null)
            {
                return Ok(buis.AddNewCustomer(customer));
            }
            else
            {
                Acustomer empty = new Acustomer() { Id = 0 };
                return Ok(empty);
            }
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            
            var cust = customerData.DeleteCustomer(id);
            if(cust == null)
            {
                return Ok();
            }
            return NotFound();
            
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(int id, Acustomer customer)
        {
            var existingCust = customerData.GetCustomer(id);
            if(existingCust != null)
            {
                customer.Id = existingCust.Id;
                customerData.EditCustomer(customer);
                return Ok(customer);
            }
            return NotFound();

        }

    }
}
