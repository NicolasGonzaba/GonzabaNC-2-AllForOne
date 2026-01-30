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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;
    public GuessItController(GuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpPost("EasyMode/{Guess}")]
    public string EasyMode(int Guess)
    {
        return _guessItService.EasyMode(Guess);
    }

    [HttpPost("MediumMode/{Guess}")]
    public string MediumMode(int Guess)
    {
        return _guessItService.MediumMode(Guess); 
    }

    [HttpPost("HardMode/{Guess}")]
    public string HardMode(int Guess)
    {
       return _guessItService.HardMode(Guess); 
    }
    }
}