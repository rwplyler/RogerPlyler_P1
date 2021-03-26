using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Controllers
{
    [ApiController]
    public class AnItemController : Controller
    {
        private IItemData itemData;
        public AnItemController(IItemData _itemData)
        {
            itemData = _itemData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(itemData.GetItems());
        }
    }
}
