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
    public class CaseTypesController : ControllerBase
    {
        ICaseTypeService _caseTypeService;

        public CaseTypesController(ICaseTypeService caseTypeService)
        {
            _caseTypeService = caseTypeService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_caseTypeService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_caseTypeService.GetById(id));
        }
        [HttpGet("GetByCaseName/{caseName}")]
        public IActionResult GetByCaseName(string caseName)
        {
            return Ok(_caseTypeService.GetByCaseName(caseName));
        }
        [HttpGet("GetByUnitTypeId_caseName/{unitTypeId}")]
        public IActionResult GetByUnitTypeId_caseName(int unitTypeId)
        {
            return Ok(_caseTypeService.GetByUnitTypeId_caseName(unitTypeId));
        }
    }
}
