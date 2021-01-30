using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HukukMahkemeleriWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitysController : ControllerBase
    {
        ICityService _cityService;

        public CitysController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_cityService.GetAll());
        }
        [HttpGet("GetByCityId/{cityId}")]
        public IActionResult GetByCityId(int cityId)
        {
            return Ok(_cityService.GetByCityId(cityId));
        }
        [HttpGet("GetByCityName/{cityName}")]
        public IActionResult GetByCityName(string cityName)
        {
            return Ok(_cityService.GetByCityName(cityName));
        }
    }
}
