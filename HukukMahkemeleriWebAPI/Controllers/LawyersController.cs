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
    public class LawyersController : ControllerBase
    {
        ILawyerService _lawyerService;

        public LawyersController(ILawyerService lawyerService)
        {
            _lawyerService = lawyerService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_lawyerService.GetAll());
        }
        [HttpGet("GetLawyerId/{lawyerId}")]
        public IActionResult GetLawyerId(int lawyerId)
        {
            return Ok(_lawyerService.GetLawyerId(lawyerId));
        }
        [HttpGet("GetLawyerSicilNo/{lawyerSicilNo}")]
        public IActionResult GetLawyerSicilNo(string lawyerSicilNo)
        {
            return Ok(_lawyerService.GetLawyerSicilNo(lawyerSicilNo));
        }
        [HttpGet("GetLawyerNameSurName/{name,surName}")]
        public IActionResult GetLawyerNameSurName(string name, string surName)
        {
            return Ok(_lawyerService.GetLawyerNameSurName(name, surName));
        }
    }
}
