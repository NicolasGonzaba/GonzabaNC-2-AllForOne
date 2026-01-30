using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    public class MadLibController
    {
        private readonly MadLibService _madLibService;

    public MadLibController(MadLibService madLibService)
    {
        _madLibService=madLibService;
    }

        [HttpGet]
        [Route("MadLib/{yourName}/{mood}/{food}/{animal}/{adjective}/{item}/{place}/{activity}")]
        public string Madlib(string yourName, string mood, string food, string animal, string adjective, string item, string place, string activity)
        {
             return _madLibService.Madlib(yourName, mood, food, animal, adjective, item, place, activity);
        }
    }
}