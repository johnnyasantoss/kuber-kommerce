using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace KuberKommerce.Orders.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[0];
        }
    }
}