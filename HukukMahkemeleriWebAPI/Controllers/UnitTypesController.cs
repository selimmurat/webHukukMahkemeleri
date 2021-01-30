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
    public class UnitTypesController : ControllerBase
    {
        IUnitTypeService _unitTypeService;

        public UnitTypesController(IUnitTypeService unitTypeService)
        {
            _unitTypeService = unitTypeService;
        }

        [HttpGet("getAll")]
        public IActionResult GetList()
        {
            return Ok(_unitTypeService.GetAll());
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_unitTypeService.GetById(id));
        }
        [HttpGet("GetUnitTypeName/{UnitTypeName}")]
        public IActionResult GetUnitTypeName(string UnitTypeName)
        {
            return Ok(_unitTypeService.GetUnitTypeName(UnitTypeName));
        }
        [HttpGet("GetUnitTypeAreaId_TypeName/{id}")]
        public IActionResult getBySGetUnitTypeAreaId_TypeName(int id)
        {
            return Ok(_unitTypeService.GetUnitTypeAreaId_TypeName(id));
        }
    }
}
