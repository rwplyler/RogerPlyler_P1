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
        public IActionResult GetItems()
        {
            return Ok(itemData.GetItems());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetItem(int id)
        {
            return Ok(itemData.GetItem(id));
        }

        
    }
}
