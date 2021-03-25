using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository.Models;
using Repository.Data;

namespace PizzaBox.Controllers
{
    //api/Customer
    [ApiController]
    public class AcustomerController : Controller
    {
        private ICustomerData customerData;

        public AcustomerController(ICustomerData _customerData)
        {
            customerData = _customerData;
        }

        //api/Customer to get
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(customerData.GetCustomers());
        }

        //API/Customer/ID
        [HttpGet]
        [Route("api/[Controller]/{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = customerData.GetCustomer(id);
            if(customer != null)
            {
                return Ok(customer);
            }
            return NotFound();
        }
       
        
    }
}
