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
    public class ResturantPickerController : ControllerBase
    {
         private readonly ResturantPickerService _resturantPickerService;
        public ResturantPickerController(ResturantPickerService resturantPickerService)
        {
            _resturantPickerService=resturantPickerService;
        }
    [HttpPost("MexicanPizzaOrFastFood/{Category}")]
    public string Picker(string Category)
    {
        return _resturantPickerService.Picker(Category);
    }

    }
}