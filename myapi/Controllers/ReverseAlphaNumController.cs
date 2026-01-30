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
    public class ReverseAlphaNumController : ControllerBase
    {
        private readonly ReverseAlphaNumService _reverseAlphaNumService;

        public ReverseAlphaNumController(ReverseAlphaNumService reverseAlphaNumService)
        {
            _reverseAlphaNumService = reverseAlphaNumService;
        }

        [HttpGet]
        [Route("ReverseAlphaNum/{LetterNum}")]
        
        public string ReverseAlphaNum(string LetterNum)
        {
          return _reverseAlphaNumService.ReverseAlphaNum(LetterNum);
        }
    }
}