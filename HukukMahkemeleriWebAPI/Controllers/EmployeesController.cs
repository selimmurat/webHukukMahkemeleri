using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getAll")]
        public IActionResult GetList()
        {
            var result = _employeeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            var result = _employeeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getByTCKimlikNo/{tcKimlikNo}")]
        public IActionResult getByTCKimlikNo(string tcKimlikNo)
        {
            return Ok(_employeeService.GetByTC_KimlikNo(tcKimlikNo));
        }
        [HttpGet("getBySicilno/{sicilNo}")]
        public IActionResult getBySicilNo(string sicilNo)
        {
            return Ok(_employeeService.GetBySicilNo(sicilNo));
        }

        [HttpPost("createEmployee")]
        public IActionResult createEmployee(Employee employee)
        {
            var result = _employeeService.Add(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
