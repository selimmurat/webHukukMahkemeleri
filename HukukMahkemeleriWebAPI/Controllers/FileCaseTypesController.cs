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
    public class FileCaseTypesController : ControllerBase
    {
        IFileCaseTypeService _fileCaseTypeService;

        public FileCaseTypesController(IFileCaseTypeService fileCaseTypeService)
        {
            _fileCaseTypeService = fileCaseTypeService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_fileCaseTypeService.GetAll());
        }
        [HttpGet("GetByFileId/{fileId}")]
        public IActionResult GetByFileId(int fileId)
        {
            return Ok(_fileCaseTypeService.GetByFileId(fileId));
        }
    }
}
