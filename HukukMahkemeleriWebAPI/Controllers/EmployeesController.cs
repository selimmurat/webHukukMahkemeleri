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
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("getById/{id}")]
        public IActionResult getById(int id)
        {
            return Ok(_employeeService.GetById(id));
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
        public string createEmployee(Employee employee)
        {
           _employeeService.Add(employee);
            return "kayıt başarılı";
            
        }
    }
}
