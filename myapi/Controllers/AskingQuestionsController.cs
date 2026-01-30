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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsService _askingQuestionsService;
        public AskingQuestionsController(AskingQuestionsService askingQuestionsService)
        {
            _askingQuestionsService=askingQuestionsService;
        }
        [HttpGet]
        [Route("Questions/{userName}/{userTime}")]
        public string NameTime(string userName, string userTime)
        {
            return _askingQuestionsService.NameTime(userName, userTime);
        }
    }
}