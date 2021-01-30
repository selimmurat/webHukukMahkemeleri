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
    public class FileRegisterPersonsController : ControllerBase
    {
        IFileRegisterPersonService _fileRegisterPersonService;

        public FileRegisterPersonsController(IFileRegisterPersonService fileRegisterPersonService)
        {
            _fileRegisterPersonService = fileRegisterPersonService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileRegisterPersonService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_fileRegisterPersonService.GetById(id));
        }
        [HttpGet("GetByFileId/{fileId}")]
        public IActionResult GetByFileId(int fileId)
        {
            return Ok(_fileRegisterPersonService.GetByFileId(fileId));
        }
        [HttpGet("GetByPersonId/{personId}")]
        public IActionResult GetByPersonId(int personId)
        {
            return Ok(_fileRegisterPersonService.GetByPersonId(personId));
        }
    }
}
