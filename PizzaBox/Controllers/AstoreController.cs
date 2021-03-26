using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.Controllers
{
    [ApiController]
    public class AstoreController : Controller
    {
        private IStoreData storeData;
        public AstoreController(IStoreData _storeData)
        {
            storeData = _storeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStores()
        {
            return Ok(storeData.GetStores());
        }
    }
}
