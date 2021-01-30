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
    public class UnitAreasController : ControllerBase
    {
        IUnitAreaService _unitAreaService;

        public UnitAreasController(IUnitAreaService unitAreaService)
        {
            _unitAreaService = unitAreaService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_unitAreaService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_unitAreaService.GetByAreaId(id));
        }
        [HttpGet("GetByAreaName/{areaName}")]
        public IActionResult GetByAreaName(string areaName)
        {
            return Ok(_unitAreaService.GetByAreaName(areaName));
        }
    }
}
