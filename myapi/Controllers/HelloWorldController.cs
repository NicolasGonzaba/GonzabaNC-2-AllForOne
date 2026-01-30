using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldSevice _helloWorldService;
        public HelloWorldController(HelloWorldSevice helloWorldSevice)
        {
            _helloWorldService=helloWorldSevice;
        }
        
        [HttpGet]
        [Route("HelloWorld")]
        public string HelloWorld()
    {
        return _helloWorldService.HelloWorld();
    }
    }
