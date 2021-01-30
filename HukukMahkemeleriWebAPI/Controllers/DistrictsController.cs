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
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_districtService.GetAll());
        }
        [HttpGet("GetByCityId/{cityId}")]
        public IActionResult GetByCityId(int cityId)
        {
            return Ok(_districtService.GetByCityId(cityId));
        }
        [HttpGet("GetById/{districtId}")]
        public IActionResult GetById(int districtId)
        {
            return Ok(_districtService.GetById(districtId));
        }
        [HttpGet("GetByName/{districtName}")]
        public IActionResult GetByName(string districtName)
        {
            return Ok(_districtService.GetByName(districtName));
        }
    }
}
