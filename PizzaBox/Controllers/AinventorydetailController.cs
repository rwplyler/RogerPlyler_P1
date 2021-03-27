using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Controllers
{
    [ApiController]
    public class AinventorydetailController : Controller
    {
        IInventoryDetail inventorydetaildata;
        public AinventorydetailController(IInventoryDetail _inventorydetaildata)
        {
            inventorydetaildata = _inventorydetaildata;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAllInvetoryDetail()
        {
            return Ok(inventorydetaildata.GetInventoryDetails());
        }

    }
}
