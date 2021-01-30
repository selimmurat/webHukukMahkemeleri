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
    public class LawWaysController : ControllerBase
    {
        ILawWayService _lawWayService;

        public LawWaysController(ILawWayService lawWayService)
        {
            _lawWayService = lawWayService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_lawWayService.GetAll());
        }
        [HttpGet("GetByLawWayId/{id}")]
        public IActionResult GetByLawWayId(int id)
        {
            return Ok(_lawWayService.GetByLawWayId(id));
        }
        [HttpGet("GetByLawWayName/{lawWayName}")]
        public IActionResult GetByLawWayName(string lawWayName)
        {
            return Ok(_lawWayService.GetByLawWayName(lawWayName));
        }
    }
}
