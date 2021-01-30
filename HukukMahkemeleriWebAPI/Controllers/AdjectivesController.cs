using Business.Abstract;
using Entities.Concrete;
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
    public class AdjectivesController : ControllerBase
    {
        IAdjectiveService _adjectiveService;

        public AdjectivesController(IAdjectiveService adjectiveService)
        {
            _adjectiveService = adjectiveService;
        }

        [HttpGet("getAll")]
        public IActionResult getList()
        {
            return Ok(_adjectiveService.GetAll());
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_adjectiveService.GetById(id));
        }

        [HttpGet("getByName/{adjectiveName}")]
        public IActionResult getName(string adjectiveName)
        {
            return Ok(_adjectiveService.GetByName(adjectiveName));
        }
    }
}
