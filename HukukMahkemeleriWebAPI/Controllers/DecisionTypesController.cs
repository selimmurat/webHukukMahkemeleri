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
    public class DecisionTypesController : ControllerBase
    {
        IDecisionTypeService _decisionTypeService;

        public DecisionTypesController(IDecisionTypeService decisionTypeService)
        {
            _decisionTypeService = decisionTypeService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_decisionTypeService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_decisionTypeService.GetById(id));
        }
        [HttpGet("GetByName/{decisionName}")]
        public IActionResult GetByName(string decisionName)
        {
            return Ok(_decisionTypeService.GetByName(decisionName));
        }
    }
}
