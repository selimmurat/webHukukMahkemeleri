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
    public class UnitsController : ControllerBase
    {
        IUnitService _unitService;

        public UnitsController(IUnitService unitService)
        {
            _unitService = unitService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_unitService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_unitService.GetById(id));
        }
        [HttpGet("GetByCode/{id}")]
        public IActionResult GetByCode(int id)
        {
            return Ok(_unitService.GetByCode(id));
        }
        [HttpGet("GetByUnitName/{unitName}")]
        public IActionResult GetByUnitName(string unitName)
        {
            return Ok(_unitService.GetByUnitName(unitName));
        }
        [HttpGet("GetByTypeId_Units/{typeId}")]
        public IActionResult GetByTypeId_Units(int typeId)
        {
            return Ok(_unitService.GetByTypeId_Units(typeId));
        }

    }
}
