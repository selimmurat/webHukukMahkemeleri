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
    public class CompanysController : ControllerBase
    {
        ICompanyService _companyService;

        public CompanysController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getAll")]
        public IActionResult GetList()
        {
            return Ok(_companyService.GetAll());
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_companyService.GetById(id));
        }
        [HttpGet("GetByMersisNo/{mersisNo}")]
        public IActionResult GetByMersisNo(int mersisNo)
        {
            return Ok(_companyService.GetByMersisNo(mersisNo));
        }
        [HttpGet("GetByVergiNo/{id}")]
        public IActionResult GetByVergiNo(int vergiNo)
        {
            return Ok(_companyService.GetByVergiNo(vergiNo));
        }
        [HttpGet("GetByName/{companyName}")]
        public IActionResult GetByName(string companyName)
        {
            return Ok(_companyService.GetByName(companyName));
        }
    }
}
