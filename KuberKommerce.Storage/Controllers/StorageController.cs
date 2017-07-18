using System.Collections.Generic;
using KuberKommerce.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KuberKommerce.Storage.Controllers
{
    [Route("api/[controller]")]
    public class StorageController : Controller
    {
        private readonly IHttpService _httpService;

        public StorageController(
            IHttpService httpService
        )
        {
            _httpService = httpService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[0];
        }
    }
}