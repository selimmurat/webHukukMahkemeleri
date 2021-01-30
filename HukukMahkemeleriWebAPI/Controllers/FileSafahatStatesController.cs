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
    public class FileSafahatStatesController : ControllerBase
    {
        IFileSafahatStateService _fileSafahatStateService;

        public FileSafahatStatesController(IFileSafahatStateService fileSafahatStateService)
        {
            _fileSafahatStateService = fileSafahatStateService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileSafahatStateService.GetAll());
        }
    }
}
