using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService=oddOrEvenService;
        }

        [HttpGet]
        [Route("OddOrEven/{num}")]
        
        public string OddOrEven(int num)
        {
            return _oddOrEvenService.OddOrEven(num);
        }
    }
}