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
    public class UnitOpenFilesController : ControllerBase
    {
        IUnitOpenFileService _unitOpenFileService;

        public UnitOpenFilesController(IUnitOpenFileService unitOpenFileService)
        {
            _unitOpenFileService = unitOpenFileService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_unitOpenFileService.GetAll());
        }
    }
}
