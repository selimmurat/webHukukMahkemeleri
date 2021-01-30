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
    public class UnitEndProcessRowNumbersController : ControllerBase
    {
        IUnitEndProcessRowNumberService _unitEndProcessRowNumberService;

        public UnitEndProcessRowNumbersController(IUnitEndProcessRowNumberService unitEndProcessRowNumberService)
        {
            _unitEndProcessRowNumberService = unitEndProcessRowNumberService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_unitEndProcessRowNumberService.GetAll());
        }
    }
}
