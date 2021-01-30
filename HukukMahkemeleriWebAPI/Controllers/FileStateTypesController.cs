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
    public class FileStateTypesController : ControllerBase
    {
        IFileStateTypeService _fileStateTypeService;

        public FileStateTypesController(IFileStateTypeService fileStateTypeService)
        {
            _fileStateTypeService = fileStateTypeService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileStateTypeService.GetAll());
        }
        [HttpGet("GetFileStateTypeId/{id}")]
        public IActionResult GetFileStateTypeId(int id)
        {
            return Ok(_fileStateTypeService.GetFileStateTypeId(id));
        }
        [HttpGet("GetFileStateName/{stateName}")]
        public IActionResult GetFileStateName(string stateName)
        {
            return Ok(_fileStateTypeService.GetFileStateName(stateName));
        }
    }
}
