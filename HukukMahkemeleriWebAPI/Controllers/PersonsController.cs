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
    public class PersonsController : ControllerBase
    {
        IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_personService.GetAll());
        }
        [HttpGet("GetByPersonId/{personId}")]
        public IActionResult GetByPersonId(int personId)
        {
            return Ok(_personService.GetByPersonId(personId));
        }
        [HttpGet("GetByPersonTCNO/{personTCNo}")]
        public IActionResult GetByPersonTCNO(string personTCNo)
        {
            return Ok(_personService.GetByPersonTCNO(personTCNo));
        }
        [HttpGet("GetByPersonNameSurname/{personName,personSurName}")]
        public IActionResult GetByPersonNameSurname(string personName, string personSurName)
        {
            return Ok(_personService.GetByPersonNameSurname(personName,personSurName));
        }
    }
}
