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
    public class FileTypesController : ControllerBase
    {
        IFileTypeService _fileTypeService;

        public FileTypesController(IFileTypeService fileTypeService)
        {
            _fileTypeService = fileTypeService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileTypeService.GetAll());
        }
        [HttpGet("GetFileTypeId/{id}")]
        public IActionResult GetFileTypeId(int id)
        {
            return Ok(_fileTypeService.GetFileTypeId(id));
        }
        [HttpGet("GetFileTypeName/{typeName}")]
        public IActionResult GetFileTypeName(string typeName)
        {
            return Ok(_fileTypeService.GetFileTypeName(typeName));
        }
    }
}
