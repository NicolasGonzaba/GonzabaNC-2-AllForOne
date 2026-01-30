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
    public class AddNumbersController : ControllerBase
    {
        private readonly AddNumbersService _addNumbersService;
        public AddNumbersController(AddNumbersService addNumbersService)
        {
            _addNumbersService=addNumbersService;
        }
        [HttpGet]
        [Route("TwoNumbers/{num1}/{num2}")]
        public string TwoNumbers(int num1, int num2)
        {
            return _addNumbersService.AddTwo(num1, num2);
        }
    }
}