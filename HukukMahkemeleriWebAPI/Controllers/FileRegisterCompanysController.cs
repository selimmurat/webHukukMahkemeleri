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
    public class FileRegisterCompanysController : ControllerBase
    {
        IFileRegisterCompanyService _fileRegisterCompanyService;

        public FileRegisterCompanysController(IFileRegisterCompanyService fileRegisterCompanyService)
        {
            _fileRegisterCompanyService = fileRegisterCompanyService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_fileRegisterCompanyService.GetAll());
        }
        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_fileRegisterCompanyService.GetById(id));
        }
        [HttpGet("GetByFileId/{fileId}")]
        public IActionResult GetByFileId(int fileId)
        {
            return Ok(_fileRegisterCompanyService.GetByFileId(fileId));
        }
        [HttpGet("GetByCompnayId/{companyId}")]
        public IActionResult GetByCompnayId(int companyId)
        {
            return Ok(_fileRegisterCompanyService.GetByCompnayId(companyId));
        }
    }
}
