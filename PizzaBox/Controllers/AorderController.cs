using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Controllers
{
    [ApiController]
    public class AorderController : Controller
    {
        private IOrderData orderData;
        public AorderController(IOrderData _orderData)
        {
            orderData = _orderData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetOrders()
        {
            return Ok(orderData.GetOrders());
        }

        [HttpGet]
        [Route("api/[controller]/{id}/store")]
        public IActionResult GetOrdersStore(int id)
        {
            return Ok(orderData.GetOrdersByStore(id));
        }

        [HttpGet]
        [Route("api/[controller]/{id}/customer")]
        public IActionResult GetOrdersCustomer(int id)
        {
            return Ok(orderData.GetOrdersByCustomer(id));
        }
    }
}
