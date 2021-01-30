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
    public class FileUnderConnectionsController : ControllerBase
    {
        IFileUnderConnectionService _fileUnderConnectionService;

        public FileUnderConnectionsController(IFileUnderConnectionService fileUnderConnectionService)
        {
            _fileUnderConnectionService = fileUnderConnectionService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileUnderConnectionService.GetAll());
        }
    }
}
