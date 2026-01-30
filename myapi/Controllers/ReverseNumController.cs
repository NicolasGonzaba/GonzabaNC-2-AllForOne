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
    public class ReverseNumController : ControllerBase
    {
        private readonly ReverseNumService _reverseNumService;

        public ReverseNumController(ReverseNumService reverseNumService)
        {
            _reverseNumService = reverseNumService;
        }

        [HttpGet]
        [Route("ReverseItNum/{digits}")]
        
        public string ReverseItNum(int digits)
        {
            return _reverseNumService.ReverseNum(digits);
        }
    }
}