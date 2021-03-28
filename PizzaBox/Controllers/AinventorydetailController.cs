using Microsoft.AspNetCore.Mvc;
using Models;
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

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetStoreInventory(int id)
        {
            return Ok(inventorydetaildata.GetInventoryStore(id));
        }

        [HttpGet]
        [Route("api/[controller]/{id}/{storeid}")]
        public IActionResult GetStoreItemInventory(int id, int storeid)
        {
            return Ok(inventorydetaildata.GetInventoryItem(id, storeid));
        }

        [HttpGet]
        [Route("api/[controller]/{itemid}/{storeid}/{amount}/{orderid}")]
        public IActionResult SubmitItemsToOrder(int itemid,int storeid,int amount,int orderid)
        {
            return Ok();
        }

    }
}
